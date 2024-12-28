using System;
using Python.Runtime;

internal class Program
{
    private static void Main(string[] args)
    {
        // Enable BinaryFormatter (for Python.Runtime)
        AppContext.SetSwitch("System.Runtime.Serialization.Formatters.Binary.AllowBinaryFormatter", true);

        try
        {
            // Set PythonHome to the Python installation directory (not the DLL file)
            Runtime.PythonDLL = @"C:\Users\mehed\AppData\Local\Programs\Python\Python310\python310.dll"; // Path to the Python DLL

            // Initialize the Python engine
            PythonEngine.Initialize();

            // Get user input for the sentence to process
            Console.WriteLine("Enter a sentence:");
            string inputText = Console.ReadLine();

            using (Py.GIL()) // Acquire the Global Interpreter Lock (GIL) for thread safety
            {
                // Import TextBlob for spelling correction
                dynamic textblob = Py.Import("textblob");

                // Create a TextBlob object for the input text
                dynamic blob = textblob.TextBlob(inputText);

                // Correct the spelling using the correct() method
                dynamic correctedBlob = blob.correct();

                // Convert the corrected text to a C# string using ToString()
                string correctedText = correctedBlob.ToString();

                // Import spaCy
                dynamic spacy = Py.Import("spacy");

                // Load the spaCy model (en_core_web_sm)
                dynamic nlp = spacy.load("en_core_web_sm");

                // Process the corrected text with spaCy
                dynamic doc = nlp(correctedText);

                // Correct the sentence structure (if necessary)
                string finalCorrectedText = doc.text.ToString();

                // Print the final corrected sentence
                Console.WriteLine("Corrected Sentence:");
                Console.WriteLine(finalCorrectedText);
            }

            // Shutdown the Python engine
            PythonEngine.Shutdown();
        }
        catch (PythonException ex)
        {
            Console.WriteLine($"Python exception occurred: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"General exception occurred: {ex.Message}");
        }
        finally
        {
            // Shutdown the Python runtime after the task is completed
            PythonEngine.Shutdown();
        }

        Console.ReadKey();
    }
}
