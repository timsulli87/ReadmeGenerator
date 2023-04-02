# ReadmeGenerator_Winforms

<br>

## **Overview**
<br>

The main entry point for the application.

<br>

## **frmMain**

Controller for the main form


### **Functions**

btn_LoadXML_Click
<ul>
<li>
Creates an open file dialog to allow user to select XML file
</li>
<li>
Parameters
<ul>
<li>Object sender</li>
<li>EventArgs) e</li>
</ul>
</li>
</ul>

btn_Generate_Click
<ul>
<li>
Calls the CreateDoc() method to read the XML file and generate the readme.md string
</li>
<li>
Parameters
<ul>
<li>Object sender</li>
<li>EventArgs) e</li>
</ul>
</li>
</ul>

btn_Save_Click
<ul>
<li>
Creates a save file dialog to allow user to save the readme.md file
</li>
<li>
Parameters
<ul>
<li>Object sender</li>
<li>EventArgs) e</li>
</ul>
</li>
</ul>

btn_Exit_Click
<ul>
<li>
Closes the app
</li>
<li>
Parameters
<ul>
<li>Object sender</li>
<li>EventArgs) e</li>
</ul>
</li>
</ul>

Dispose
<ul>
<li>
Clean up any resources being used.
</li>
<li>
Parameters
<ul>
<li>Boolean) disposing</li>
</ul>
</li>
</ul>

InitializeComponent
<ul>
<li>
Required method for Designer support - do not modify             the contents of this method with the code editor.
</li>
</ul>
<br>

## **ClassObj**

Class the represents the class objects of the XML document file.            The Methods, Properties, and Events class properties are lists of class objects of their corresponding classes.


### **Properties**

Name
<ul><li>Class name</li></ul>

Summary
<ul><li>Class summary</li></ul>

Methods
<ul><li>List of methods contained in the class</li></ul>

Properties
<ul><li>List of properties contained in the class</li></ul>

Events
<ul><li>List of events contained in the class</li></ul>
<br>

## **EventObj**

Class the represents the event objects of the XML document file.


### **Properties**

Name
<ul><li>Event name</li></ul>

Summary
<ul><li>Event summary</li></ul>
<br>

## **ApplicationConfiguration**

Bootstrap the application configuration.


### **Functions**

Initialize
<ul>
<li>
Bootstrap the application as follows:                          Application.EnableVisualStyles();             Application.SetCompatibleTextRenderingDefault(false);             Application.SetHighDpiMode(HighDpiMode.SystemAware);
</li>
</ul>
