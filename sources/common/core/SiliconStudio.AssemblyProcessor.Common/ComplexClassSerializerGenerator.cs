﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 11.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace SiliconStudio.AssemblyProcessor
{
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using Mono.Cecil;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\DEV\paradox\sources\common\core\SiliconStudio.AssemblyProcessor.Common\ComplexClassSerializerGenerator.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "11.0.0.0")]
    internal partial class ComplexClassSerializerGenerator : ComplexClassSerializerGeneratorBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("\r\n");
            
            #line 7 "C:\DEV\paradox\sources\common\core\SiliconStudio.AssemblyProcessor.Common\ComplexClassSerializerGenerator.tt"

    var className = SerializerTypeName(type, true, true);
	var parentType = hasParentSerializer ? ResolveGenericsVisitor.Process(type, type.BaseType) : null;

            
            #line default
            #line hidden
            this.Write("\r\nnamespace SiliconStudio.DataSerializers\r\n{\r\n\t");
            
            #line 14 "C:\DEV\paradox\sources\common\core\SiliconStudio.AssemblyProcessor.Common\ComplexClassSerializerGenerator.tt"
 if (type.HasGenericParameters) {
            
            #line default
            #line hidden
            this.Write("public ");
            
            #line 14 "C:\DEV\paradox\sources\common\core\SiliconStudio.AssemblyProcessor.Common\ComplexClassSerializerGenerator.tt"
}
            
            #line default
            #line hidden
            this.Write("sealed class ");
            
            #line 14 "C:\DEV\paradox\sources\common\core\SiliconStudio.AssemblyProcessor.Common\ComplexClassSerializerGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(className));
            
            #line default
            #line hidden
            this.Write(" : ");
            
            #line 14 "C:\DEV\paradox\sources\common\core\SiliconStudio.AssemblyProcessor.Common\ComplexClassSerializerGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(type.IsClass && !type.IsValueType && !type.IsAbstract && HasEmptyConstructor(type) ? "Class" : string.Empty));
            
            #line default
            #line hidden
            this.Write("DataSerializer<");
            
            #line 14 "C:\DEV\paradox\sources\common\core\SiliconStudio.AssemblyProcessor.Common\ComplexClassSerializerGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(type.ConvertCSharp()));
            
            #line default
            #line hidden
            this.Write(">, IDataSerializerInitializer");
            
            #line 14 "C:\DEV\paradox\sources\common\core\SiliconStudio.AssemblyProcessor.Common\ComplexClassSerializerGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GenerateGenericConstraints(type)));
            
            #line default
            #line hidden
            this.Write("\r\n\t{\r\n");
            
            #line 16 "C:\DEV\paradox\sources\common\core\SiliconStudio.AssemblyProcessor.Common\ComplexClassSerializerGenerator.tt"
if (hasParentSerializer) {
            
            #line default
            #line hidden
            this.Write("\t\tprivate DataSerializer<");
            
            #line 17 "C:\DEV\paradox\sources\common\core\SiliconStudio.AssemblyProcessor.Common\ComplexClassSerializerGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parentType.ConvertCSharp()));
            
            #line default
            #line hidden
            this.Write("> parentSerializer;\r\n");
            
            #line 18 "C:\DEV\paradox\sources\common\core\SiliconStudio.AssemblyProcessor.Common\ComplexClassSerializerGenerator.tt"
}
var serializableItems = GetSerializableItems(type, true).ToArray();

            
            #line default
            #line hidden
            
            #line 21 "C:\DEV\paradox\sources\common\core\SiliconStudio.AssemblyProcessor.Common\ComplexClassSerializerGenerator.tt"
foreach (var serializableItem in serializableItems) {
            
            #line default
            #line hidden
            this.Write("\t\tprivate DataSerializer<");
            
            #line 22 "C:\DEV\paradox\sources\common\core\SiliconStudio.AssemblyProcessor.Common\ComplexClassSerializerGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(serializableItem.Type.ConvertCSharp()));
            
            #line default
            #line hidden
            this.Write("> ");
            
            #line 22 "C:\DEV\paradox\sources\common\core\SiliconStudio.AssemblyProcessor.Common\ComplexClassSerializerGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(serializableItem.MemberInfo.Name));
            
            #line default
            #line hidden
            this.Write("Serializer;\r\n");
            
            #line 23 "C:\DEV\paradox\sources\common\core\SiliconStudio.AssemblyProcessor.Common\ComplexClassSerializerGenerator.tt"
}
            
            #line default
            #line hidden
            this.Write("\r\n\t\tpublic void Initialize(SerializerSelector serializerSelector)\r\n\t\t{\r\n");
            
            #line 27 "C:\DEV\paradox\sources\common\core\SiliconStudio.AssemblyProcessor.Common\ComplexClassSerializerGenerator.tt"
if (hasParentSerializer) {
            
            #line default
            #line hidden
            this.Write("\t\t\t// Get parent serializer\r\n\t\t\tparentSerializer = serializerSelector.GetSerializ" +
                    "er<");
            
            #line 29 "C:\DEV\paradox\sources\common\core\SiliconStudio.AssemblyProcessor.Common\ComplexClassSerializerGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parentType.ConvertCSharp()));
            
            #line default
            #line hidden
            this.Write(">();\r\n\t\t\tif (parentSerializer == null)\r\n\t\t\t\tthrow new InvalidOperationException(s" +
                    "tring.Format(\"Could not find parent serializer for type {0}\", @\"");
            
            #line 31 "C:\DEV\paradox\sources\common\core\SiliconStudio.AssemblyProcessor.Common\ComplexClassSerializerGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parentType.ConvertCSharp()));
            
            #line default
            #line hidden
            this.Write("\"));\r\n");
            
            #line 32 "C:\DEV\paradox\sources\common\core\SiliconStudio.AssemblyProcessor.Common\ComplexClassSerializerGenerator.tt"
}
            
            #line default
            #line hidden
            this.Write("\t\t\t// Cache member serializers\r\n");
            
            #line 34 "C:\DEV\paradox\sources\common\core\SiliconStudio.AssemblyProcessor.Common\ComplexClassSerializerGenerator.tt"
foreach (var serializableItem in serializableItems) {
            
            #line default
            #line hidden
            this.Write("\t\t\t");
            
            #line 35 "C:\DEV\paradox\sources\common\core\SiliconStudio.AssemblyProcessor.Common\ComplexClassSerializerGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(serializableItem.MemberInfo.Name));
            
            #line default
            #line hidden
            this.Write("Serializer = MemberSerializer<");
            
            #line 35 "C:\DEV\paradox\sources\common\core\SiliconStudio.AssemblyProcessor.Common\ComplexClassSerializerGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(serializableItem.Type.ConvertCSharp()));
            
            #line default
            #line hidden
            this.Write(">.Create(serializerSelector);\r\n");
            
            #line 36 "C:\DEV\paradox\sources\common\core\SiliconStudio.AssemblyProcessor.Common\ComplexClassSerializerGenerator.tt"
}
            
            #line default
            #line hidden
            this.Write("\t\t}\r\n\r\n\t\tpublic override void Serialize(ref ");
            
            #line 39 "C:\DEV\paradox\sources\common\core\SiliconStudio.AssemblyProcessor.Common\ComplexClassSerializerGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(type.ConvertCSharp()));
            
            #line default
            #line hidden
            this.Write(" obj, ArchiveMode mode, SerializationStream stream)\r\n\t\t{\r\n");
            
            #line 41 "C:\DEV\paradox\sources\common\core\SiliconStudio.AssemblyProcessor.Common\ComplexClassSerializerGenerator.tt"
if (hasParentSerializer) {
            
            #line default
            #line hidden
            this.Write("\t\t\t// Serialize parent (for now we don\'t copy reference back because it shouldn\'t" +
                    " change)\r\n\t\t\t");
            
            #line 43 "C:\DEV\paradox\sources\common\core\SiliconStudio.AssemblyProcessor.Common\ComplexClassSerializerGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parentType.ConvertCSharp()));
            
            #line default
            #line hidden
            this.Write(" parentObj = obj;\r\n\t\t\tparentSerializer.Serialize(ref parentObj, mode, stream);\r\n\t" +
                    "\t\tobj = (");
            
            #line 45 "C:\DEV\paradox\sources\common\core\SiliconStudio.AssemblyProcessor.Common\ComplexClassSerializerGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(type.ConvertCSharp()));
            
            #line default
            #line hidden
            this.Write(")parentObj;\r\n\r\n");
            
            #line 47 "C:\DEV\paradox\sources\common\core\SiliconStudio.AssemblyProcessor.Common\ComplexClassSerializerGenerator.tt"
}
foreach (var serializableItem in serializableItems) {
	var memberType = serializableItem.Type;
	var memberTypeName = serializableItem.Type.ConvertCSharp();
	var memberName = serializableItem.MemberInfo.Name;
	var memberVariableName = CreateMemberVariableName(serializableItem.MemberInfo);
	var memberAccessName = (serializableItem.MemberInfo is PropertyDefinition) ? memberVariableName : "obj." + memberName;

	if (serializableItem.HasFixedAttribute)
	{
            
            #line default
            #line hidden
            this.Write("\t\tthrow new NotImplementedException(\"FixedBuffer attribute is not supported.\");\r\n" +
                    "");
            
            #line 58 "C:\DEV\paradox\sources\common\core\SiliconStudio.AssemblyProcessor.Common\ComplexClassSerializerGenerator.tt"
	}
	else
	{
		if (serializableItem.MemberInfo is PropertyDefinition)
		{
            
            #line default
            #line hidden
            this.Write("            ");
            
            #line 63 "C:\DEV\paradox\sources\common\core\SiliconStudio.AssemblyProcessor.Common\ComplexClassSerializerGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(memberTypeName));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 63 "C:\DEV\paradox\sources\common\core\SiliconStudio.AssemblyProcessor.Common\ComplexClassSerializerGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(memberVariableName));
            
            #line default
            #line hidden
            this.Write(" = obj.");
            
            #line 63 "C:\DEV\paradox\sources\common\core\SiliconStudio.AssemblyProcessor.Common\ComplexClassSerializerGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(memberName));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 64 "C:\DEV\paradox\sources\common\core\SiliconStudio.AssemblyProcessor.Common\ComplexClassSerializerGenerator.tt"
}
            
            #line default
            #line hidden
            this.Write("            ");
            
            #line 65 "C:\DEV\paradox\sources\common\core\SiliconStudio.AssemblyProcessor.Common\ComplexClassSerializerGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(serializableItem.MemberInfo.Name));
            
            #line default
            #line hidden
            this.Write("Serializer.Serialize(ref ");
            
            #line 65 "C:\DEV\paradox\sources\common\core\SiliconStudio.AssemblyProcessor.Common\ComplexClassSerializerGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(memberAccessName));
            
            #line default
            #line hidden
            this.Write(", mode, stream);\r\n");
            
            #line 66 "C:\DEV\paradox\sources\common\core\SiliconStudio.AssemblyProcessor.Common\ComplexClassSerializerGenerator.tt"
if (serializableItem.MemberInfo is PropertyDefinition && serializableItem.AssignBack)
		{
            
            #line default
            #line hidden
            this.Write("            obj.");
            
            #line 68 "C:\DEV\paradox\sources\common\core\SiliconStudio.AssemblyProcessor.Common\ComplexClassSerializerGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(memberName));
            
            #line default
            #line hidden
            this.Write(" = ");
            
            #line 68 "C:\DEV\paradox\sources\common\core\SiliconStudio.AssemblyProcessor.Common\ComplexClassSerializerGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(memberVariableName));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 69 "C:\DEV\paradox\sources\common\core\SiliconStudio.AssemblyProcessor.Common\ComplexClassSerializerGenerator.tt"
}
	}
}
            
            #line default
            #line hidden
            this.Write("\t\t}\r\n\r\n\t\tinternal static void ForceGenericInstantiation()\r\n\t\t{\r\n");
            
            #line 76 "C:\DEV\paradox\sources\common\core\SiliconStudio.AssemblyProcessor.Common\ComplexClassSerializerGenerator.tt"

foreach (var memberSerializerType in EnumerateSerializerTypes(serializableItems.Select(x => x.Type))){
            
            #line default
            #line hidden
            this.Write("\t\t\ttypeof(");
            
            #line 78 "C:\DEV\paradox\sources\common\core\SiliconStudio.AssemblyProcessor.Common\ComplexClassSerializerGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(memberSerializerType.ConvertCSharp()));
            
            #line default
            #line hidden
            this.Write(").ToString();\r\n");
            
            #line 79 "C:\DEV\paradox\sources\common\core\SiliconStudio.AssemblyProcessor.Common\ComplexClassSerializerGenerator.tt"
}
            
            #line default
            #line hidden
            this.Write("\t\t}\r\n\t}\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "11.0.0.0")]
    internal class ComplexClassSerializerGeneratorBase
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