# **Text Correction using Python and .NET**

## **Purpose of the Project**
This project demonstrates how to use Python within a .NET C# Console Application to correct text input. It leverages the power of Python libraries like **spaCy** for natural language processing (NLP) and **TextBlob** for grammar and spelling correction, all integrated within a C# application using the **Python.NET** package. The application takes user input, processes it, and returns a grammatically corrected version of the text.

---

## **⚠️ This Project is Under Development ⚠️**
**Please note**: This project is **currently under development** and may not cover all edge cases for text correction. The functionality is still evolving, and updates may be made to improve its accuracy and efficiency.

---

## **Requirements**

### **Python Setup**
1. **Install Python 3.10.11**:
   - Download and install Python 3.10.11 from the official Python website: [Python Downloads](https://www.python.org/downloads/).
   - Ensure Python is added to your system's PATH.

2. **Install Python Libraries**:
   - Open **Command Prompt** and run the following commands to install the necessary Python libraries:
   
     ```bash
     pip install spacy
     python -m spacy download en_core_web_sm
     pip install pythonnet
     pip install textblob
     ```

3. **Check Python Version**:
   - Verify your Python installation by running:
   
     ```bash
     python --version
     ```

### **.NET Setup**
1. **Install NuGet Packages**:
   - In your **.NET C# Console Application**, you need to install the following **NuGet packages**:
   
     - **Python.Runtime** (version 3.0.1)
     - **pythonnet** (version 3.0.1)

   You can install these via the NuGet Package Manager or by running the following commands in **Package Manager Console**:

   ```bash
   Install-Package Python.Runtime -Version 3.0.1
   Install-Package pythonnet -Version 3.0.1
   ```

   ## **How the Application Works**

1. **User Input**:
   - The program will prompt you to **enter a sentence** via the console.

2. **Text Processing**:
   - The input sentence is then passed to **Python** where the **spaCy** library analyzes the text, and **TextBlob** performs grammatical corrections, including spelling and grammar improvements.

3. **Output**:
   - After processing, the program outputs the **corrected version** of the sentence, fixing any spelling mistakes and grammatical issues.

---

## **Example**

### Input:
```
what ur name is?
```

### **Output:**
```
what is your name?
```


### **Explanation:**
- The sentence "what ur name is?" is inputted by the user.
- The system uses **spaCy** for natural language processing and **TextBlob** to correct spelling and grammar.
- The program then outputs the corrected sentence: "what is your name?", fixing the misspelled word "ur" to "your."

---

## **Troubleshooting**

1. **Python.NET Setup**: 
   - If you encounter issues with **Python.NET** or the Python environment, ensure that the correct Python version (3.10.11) is installed and properly configured. You can check your Python installation by running `python --version` in the command prompt.

2. **Text Correction Limitations**:
   - The **TextBlob** library handles basic grammar and spelling corrections, but it may not account for all edge cases. If necessary, you can extend or modify the correction logic to suit your specific needs.

---

## **Licensing**

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
