#pragma checksum "..\..\ADMIN.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DF3C8C5F200F3F7BD2C18243DABFFD24E99CAE3BAB46330F65DE48B347310943"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Kursa4;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Kursa4 {
    
    
    /// <summary>
    /// ADMIN
    /// </summary>
    public partial class ADMIN : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\ADMIN.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtprice;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\ADMIN.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtname;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\ADMIN.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtsize;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\ADMIN.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtmaterial;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\ADMIN.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtpicture;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\ADMIN.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtnumberbike;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\ADMIN.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtdescriptrion;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\ADMIN.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txttype;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\ADMIN.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid lbTodoList;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\ADMIN.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame frame;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Kursa4;component/admin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ADMIN.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 12 "..\..\ADMIN.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 14 "..\..\ADMIN.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Delete);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 15 "..\..\ADMIN.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtprice = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\ADMIN.xaml"
            this.txtprice.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.price_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtsize = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtmaterial = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txtpicture = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\ADMIN.xaml"
            this.txtpicture.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.picture_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 9:
            this.txtnumberbike = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\ADMIN.xaml"
            this.txtnumberbike.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.number_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 10:
            this.txtdescriptrion = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.txttype = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.lbTodoList = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 13:
            this.frame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

