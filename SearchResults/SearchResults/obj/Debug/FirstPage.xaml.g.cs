// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.17020
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace SearchResults {
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    
    
    public partial class FirstPage : ContentPage {
        
        private ListView searchresultlist;
        
        private StackLayout savedSearchRootLayout;
        
        private Image closeSaveSearchIcon;
        
        private Entry saveSearchEntry;
        
        private StackLayout AddProfileSave;
        
        private StackLayout AddProfileSaveButton;
        
        private void InitializeComponent() {
            this.LoadFromXaml(typeof(FirstPage));
            searchresultlist = this.FindByName <ListView>("searchresultlist");
            savedSearchRootLayout = this.FindByName <StackLayout>("savedSearchRootLayout");
            closeSaveSearchIcon = this.FindByName <Image>("closeSaveSearchIcon");
            saveSearchEntry = this.FindByName <Entry>("saveSearchEntry");
            AddProfileSave = this.FindByName <StackLayout>("AddProfileSave");
            AddProfileSaveButton = this.FindByName <StackLayout>("AddProfileSaveButton");
        }
    }
}
