﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace api_generator.Templates
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class blank_object_h : blank_object_hBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("\r\n");
            
            #line 7 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"
 
var allProps = Program.GetListOfPropertiesToGenerate(ObjectName); 

            
            #line default
            #line hidden
            this.Write("\r\n// Copyright (c) Microsoft. All rights reserved.\r\n// Licensed under the MIT lic" +
                    "ense. See LICENSE file in the project root for full license information.\r\n\r\n//\r\n" +
                    "");
            
            #line 15 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"
 

            
            #line default
            #line hidden
            this.Write("// Simple implementation of IoTHub LWM2M ");
            
            #line 17 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectName));
            
            #line default
            #line hidden
            this.Write(" object\r\n//\r\n\r\n//     This code was generated by a tool.\r\n//\r\n//     Changes to t" +
                    "his file may cause incorrect behavior and will be lost if\r\n//     the code is re" +
                    "generated.\r\n\r\n#ifndef _");
            
            #line 25 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectCodeName.ToUpper()));
            
            #line default
            #line hidden
            this.Write("_OBJECT_H_\r\n#define _");
            
            #line 26 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectCodeName.ToUpper()));
            
            #line default
            #line hidden
            this.Write("_OBJECT_H_\r\n\r\n#include \"iothub_client.h\"\r\n\r\n#ifdef __cplusplus\r\nextern \"C\"\r\n{\r\n#e" +
                    "ndif\r\n\r\n// LWM2M Object IDs and Property IDs for ");
            
            #line 35 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectCodeName));
            
            #line default
            #line hidden
            this.Write(" object\r\n#define OID_");
            
            #line 36 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectCodeName.ToUpper()));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 36 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectId));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 37 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"

foreach (var prop in allProps)
{

            
            #line default
            #line hidden
            this.Write("#define PID_");
            
            #line 41 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.PropertyName.ToUpper()));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 41 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.PropertyId));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 42 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"

}

            
            #line default
            #line hidden
            this.Write("\r\n#define ");
            
            #line 46 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectCodeName.ToUpper()));
            
            #line default
            #line hidden
            this.Write("_PROPERTY_COUNT ");
            
            #line 46 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PropertyCount));
            
            #line default
            #line hidden
            this.Write("\r\n\r\ntypedef struct TAG_");
            
            #line 48 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectStructName));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 48 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectStructName));
            
            #line default
            #line hidden
            this.Write(";\r\ntypedef IOTHUB_CLIENT_RESULT(*");
            
            #line 49 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectCodeName.ToUpper()));
            
            #line default
            #line hidden
            this.Write("_RESOURCE_CALLBACK)(");
            
            #line 49 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectStructName));
            
            #line default
            #line hidden
            this.Write(" *obj);\r\n\r\n// Object definition for ");
            
            #line 51 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectCodeName));
            
            #line default
            #line hidden
            this.Write(" object\r\ntypedef struct TAG_");
            
            #line 52 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectStructName));
            
            #line default
            #line hidden
            this.Write(" {\r\n    uint16_t instanceId;    // Must be first member of structure\r\n    IOTHUB_" +
                    "CHANNEL_HANDLE channelHandle;\r\n    char resourceUpdated[");
            
            #line 55 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectCodeName.ToUpper()));
            
            #line default
            #line hidden
            this.Write("_PROPERTY_COUNT];\r\n");
            
            #line 56 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"

    foreach (var prop in allProps)
    {
        if (prop.CanWrite || prop.CanRead)
        { 

            
            #line default
            #line hidden
            this.Write("    ");
            
            #line 62 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.PropertyTypeCodeName));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 62 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.SampleVariableName));
            
            #line default
            #line hidden
            this.Write(";        // /");
            
            #line 62 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectId));
            
            #line default
            #line hidden
            this.Write("/x/");
            
            #line 62 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.PropertyId));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 63 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"

        }
    }
    foreach(var prop in allProps)
    {
        if (prop.CanRead)
        {

            
            #line default
            #line hidden
            this.Write("    ");
            
            #line 71 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectCodeName.ToUpper()));
            
            #line default
            #line hidden
            this.Write("_RESOURCE_CALLBACK ");
            
            #line 71 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.PropertyName.ToLower()));
            
            #line default
            #line hidden
            this.Write("_read_callback;\r\n");
            
            #line 72 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"

        }
        if (prop.CanWrite)
        {

            
            #line default
            #line hidden
            this.Write("    ");
            
            #line 77 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectCodeName.ToUpper()));
            
            #line default
            #line hidden
            this.Write("_RESOURCE_CALLBACK ");
            
            #line 77 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.PropertyName.ToLower()));
            
            #line default
            #line hidden
            this.Write("_write_callback;\r\n");
            
            #line 78 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"

        }
        if (prop.CanExecute)
        {

            
            #line default
            #line hidden
            this.Write("    ");
            
            #line 83 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectCodeName.ToUpper()));
            
            #line default
            #line hidden
            this.Write("_RESOURCE_CALLBACK ");
            
            #line 83 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.PropertyName.ToLower()));
            
            #line default
            #line hidden
            this.Write("_execute_callback;\r\n");
            
            #line 84 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"

        }
    }

            
            #line default
            #line hidden
            this.Write("} ");
            
            #line 88 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectStructName));
            
            #line default
            #line hidden
            this.Write(";\r\n\r\nIOTHUB_CLIENT_RESULT create_");
            
            #line 90 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectCodeName));
            
            #line default
            #line hidden
            this.Write("_object(IOTHUB_CLIENT_HANDLE h, uint16_t *instanceId);\r\n");
            
            #line 91 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectStructName));
            
            #line default
            #line hidden
            this.Write(" *get_");
            
            #line 91 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectCodeName));
            
            #line default
            #line hidden
            this.Write("_object(uint16_t instanceId);\r\n\r\n// Property setters for ");
            
            #line 93 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectCodeName));
            
            #line default
            #line hidden
            this.Write(" object\r\n");
            
            #line 94 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"

foreach (var prop in allProps)
{
    if (prop.CanRead)
    { 

            
            #line default
            #line hidden
            
            #line 100 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetSetterPrototype(prop)));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 101 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"

    }
}

            
            #line default
            #line hidden
            this.Write("\r\n#ifdef __cplusplus\r\n}\r\n#endif\r\n\r\n#endif // _");
            
            #line 110 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectCodeName.ToUpper()));
            
            #line default
            #line hidden
            this.Write("_OBJECT_H_\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 112 "H:\repos\azure-iot-sdks\c\iotdm_client\tools\api_generator\Templates\blank_object_h.tt"
 

public string ObjectName;

public uint ObjectId;

public int PropertyCount;

public string ObjectCodeName
{
    get
    {
        return ObjectName.Replace(" ","").ToLower();
    }
}

public string ObjectStructName
{
    get
    {
        return "object_" + ObjectCodeName;
    }
}

private string GetSetterPrototype(PropertyToGenerate prop)
{
// BKTODO: should this return result or void?
    if (prop.Type == LWM2MObjectItemType.Opaque)
    {
        return "IOTHUB_CLIENT_RESULT set_" + prop.PropertyName.ToLower() + "(uint16_t instanceId, " + prop.PropertyTypeCodeName + " value, size_t length)";
    }
    else
    {
        return "IOTHUB_CLIENT_RESULT set_" + prop.PropertyName.ToLower() + "(uint16_t instanceId, " + prop.PropertyTypeCodeName + " value)";
    }
}


        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public class blank_object_hBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
