﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本: 17.0.0.0
//  
//     对此文件的更改可能导致不正确的行为，如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Mkh.Tools.CLI.Templates.Default.src.UI.Web
{
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\MKH\Mkh.Tools.CLI\src\Mkh.Tools.CLI\Templates\Default\src\UI\Web\PackageJson.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class PackageJson : PackageJsonBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("{\r\n  \"id\": ");
            
            #line 3 "D:\MKH\Mkh.Tools.CLI\src\Mkh.Tools.CLI\Templates\Default\src\UI\Web\PackageJson.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_model.Module.No));
            
            #line default
            #line hidden
            this.Write(",\r\n  \"name\": \"mkh-mod-");
            
            #line 4 "D:\MKH\Mkh.Tools.CLI\src\Mkh.Tools.CLI\Templates\Default\src\UI\Web\PackageJson.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_model.Module.Code.ToLower()));
            
            #line default
            #line hidden
            this.Write("\",\r\n  \"label\": \"");
            
            #line 5 "D:\MKH\Mkh.Tools.CLI\src\Mkh.Tools.CLI\Templates\Default\src\UI\Web\PackageJson.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_model.Module.Name));
            
            #line default
            #line hidden
            this.Write("\",\r\n  \"version\": \"1.0.0\",\r\n  \"icon\": \"");
            
            #line 7 "D:\MKH\Mkh.Tools.CLI\src\Mkh.Tools.CLI\Templates\Default\src\UI\Web\PackageJson.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_model.Module.Icon));
            
            #line default
            #line hidden
            this.Write("\",\r\n  \"description\": \"");
            
            #line 8 "D:\MKH\Mkh.Tools.CLI\src\Mkh.Tools.CLI\Templates\Default\src\UI\Web\PackageJson.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_model.Module.Remarks));
            
            #line default
            #line hidden
            this.Write(@""",
  ""type"": ""module"",
  ""main"": ""lib/index.js"",
  ""scripts"": {
    ""dev"": ""vite --host --config=./build/app.config.ts"",
    ""serve"": ""vite preview"",
    ""build"": ""vue-tsc --noEmit && vite build --config=./build/app.config.ts"",
    ""lib"": ""npm run clean && vite build --config=./build/lib.config.ts && npm run locales && npm run build:dts"",
    ""locales"": ""rollup -c ./build/locales.config.ts --configPlugin typescript"",
    ""build:dts"": ""npm run build-temp-types && npm run patch-types && api-extractor run && rimraf ./.temp"",
    ""build-temp-types"": ""tsc --emitDeclarationOnly -p ./tsconfig.lib.json --outDir ./.temp"",
    ""patch-types"": ""ts-node-esm ./build/patch-types.ts"",
    ""clean"": ""rimraf lib && rimraf public && rimraf dist && rimraf ./.temp"",
    ""cm"": ""rimraf package-lock.json && rimraf node_modules"",
    ""cv"": ""rimraf node_modules/.vite""
  },
  ""dependencies"": {
    ""mkh-mod-admin"": ""^");
            
            #line 25 "D:\MKH\Mkh.Tools.CLI\src\Mkh.Tools.CLI\Templates\Default\src\UI\Web\PackageJson.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_model.NPMPackageVersions.Mod_Admin));
            
            #line default
            #line hidden
            this.Write("\",\r\n    \"mkh-ui\": \"^");
            
            #line 26 "D:\MKH\Mkh.Tools.CLI\src\Mkh.Tools.CLI\Templates\Default\src\UI\Web\PackageJson.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_model.NPMPackageVersions.UI));
            
            #line default
            #line hidden
            this.Write(@"""
  },
  ""devDependencies"": {
    ""@microsoft/api-extractor"": ""^7.33.6"",
    ""@rollup/plugin-typescript"": ""^9.0.2"",
    ""@types/echarts"": ""^4.9.16"",
    ""@types/ejs"": ""^3.1.1"",
    ""@types/fs-extra"": ""^9.0.13"",
    ""@types/html-minifier-terser"": ""^7.0.0"",
    ""@types/node"": ""^18.11.9"",
    ""@types/nprogress"": ""^0.2.0"",
    ""@types/sortablejs"": ""^1.15.0"",
    ""@typescript-eslint/eslint-plugin"": ""^5.43.0"",
    ""@typescript-eslint/parser"": ""^5.43.0"",
    ""@vitejs/plugin-vue"": ""^3.2.0"",
    ""@vue/eslint-config-prettier"": ""^7.0.0"",
    ""@vue/eslint-config-typescript"": ""^11.0.2"",
    ""ejs"": ""^3.1.8"",
    ""eslint"": ""^8.28.0"",
    ""eslint-plugin-prettier"": ""^4.2.1"",
    ""eslint-plugin-vue"": ""^9.7.0"",
    ""fast-glob"": ""^3.2.12"",
    ""fs-extra"": ""^10.1.0"",
    ""html-minifier-terser"": ""^7.0.0"",
    ""prettier"": ""^2.7.1"",
    ""rollup"": ""^3.3.0"",
    ""rollup-plugin-typescript2"": ""^0.34.1"",
    ""sass"": ""^1.56.1"",
    ""stylelint"": ""^14.15.0"",
    ""stylelint-config-recommended"": ""^9.0.0"",
    ""stylelint-config-standard"": ""^29.0.0"",
    ""ts-node"": ""^10.9.1"",
    ""typescript"": ""^4.9.3"",
    ""vite"": ""^3.2.4"",
    ""vue-tsc"": ""^1.0.9""
  },
  ""files"": [
    ""lib""
  ],
  ""publishConfig"": {
    ""registry"": """"
  }
}
");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public class PackageJsonBase
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
