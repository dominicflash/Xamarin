using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Diagnostics;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace SearchResults
{
	public partial class FirstPage : ContentPage
	{

		ObservableCollection<SearchResultUIBean> list = null;

		public class SearchResultUIBean : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			public string promoSource { get; set; }
			public string title { get; set; }
			public string subTitle { get; set; }
			public string price { get; set; }
			public string stock { get; set; }
			public string imageUrl { get; set; }
			public string productCode { get; set; }
			public string qty { get; set; }

			public string QTY {
				get { return qty; }
				set {
					qty = value;

					if (PropertyChanged != null) {
						PropertyChanged (this, new PropertyChangedEventArgs ("QTY"));
					}
				}
			}
		}



		public FirstPage ()
		{
			InitializeComponent ();

			list = new ObservableCollection<SearchResultUIBean> ();
			this.addProductsToList ();


			//Set SearchResultsList view height for iOS
			if (Device.OS == TargetPlatform.iOS) {
				searchresultlist.RowHeight = 110;
			}

			searchresultlist.ItemsSource = list;

			//Gesture recognizers for close and save search events
			TapGestureRecognizer closeSaveSearchIconGesture = new TapGestureRecognizer ();
			closeSaveSearchIconGesture.NumberOfTapsRequired = 1;
			closeSaveSearchIconGesture.Tapped += closeSaveSearch;
			closeSaveSearchIcon.GestureRecognizers.Add (closeSaveSearchIconGesture);

			TapGestureRecognizer saveSearchSaveGesture = new TapGestureRecognizer ();
			saveSearchSaveGesture.NumberOfTapsRequired = 1;
			saveSearchSaveGesture.Tapped += saveSearchSave;
			AddProfileSaveButton.GestureRecognizers.Add (saveSearchSaveGesture);




		}
		void addProductsToList()
		{
			productWithDetail ("searchpromo","RT-AC3200","PA249Q Asus LCD Monitor 24 IPS LED 16 9 1920x1200 6ms 350nits 80M 1 99 Adobe RGB","250","100","image","QR-CD65ghdCV","50");
			productWithDetail ("searchpromo","KU-AC3200","AA249Q  16 9 1920x1200 6ms 350nits 80M 1 99 Adobe RGB","250","100","image","QR-CD65ghdCV","510");
			productWithDetail ("searchpromo","FT-AC3200","Asus LCD Monitor 24 IPS LED 16 9 1920x1200 6ms 350nits 80M 1 99 Adobe RGB" ,"250","1000","image","DQ-CD65ghdCV","250");
			productWithDetail ("searchpromo","QN-AC3200","LCD Monitor 24 IPS LED 16 9 1920x1200 6ms 350nits 80M 1 99 Adobe RGB","250","500","image","AR-CD65ghdCV","70");
			productWithDetail ("searchpromo","RT-AC3200","Monitor 24 IPS LED 16 9 1920x1200 6ms 350nits 80M 1 99 Adobe RGB" ,"250","50","image","CS-CD65ghdCV","150");
			productWithDetail ("searchpromo","AT-AC3200","6ms 350nits 80M 1 99 Adobe RGB","250","0","image","54-CD65ghdCV","150");
			productWithDetail ("searchpromo","GT-AC3200","PA249Q Asus LCD Monitor 24 IPS LED 16 9 1920x1200 6ms 350nits 80M 1 99 Adobe RGB", "250","10","image","MH-CD65ghdCV","350");
			productWithDetail ("searchpromo","FT-AC3200","Asus LCD Monitor 24 IPS LED 16 9 1920x1200 6ms 350nits 80M 1 99 Adobe RGB" ,"250","1000","image","DQ-CD65ghdCV","250");
			productWithDetail ("searchpromo","QN-AC3200","LCD Monitor 24 IPS LED 16 9 1920x1200 6ms 350nits 80M 1 99 Adobe RGB" ,"250","500","image","AR-CD65ghdCV","70");
			productWithDetail ("searchpromo","RT-AC3200","Monitor 24 IPS LED 16 9 1920x1200 6ms 350nits 80M 1 99 Adobe RGB","250","50","image","CS-CD65ghdCV","150");

		}
		void productWithDetail (string promoSource, string title, string subTitle,string price, string stock, string imageURl, string productCode,string quantity)
		{

			SearchResultUIBean bean = new SearchResultUIBean ();
			bean.promoSource = promoSource;
			bean.title = title;
			bean.subTitle = subTitle;
			bean.price = price;
			bean.stock = stock;
			bean.imageUrl = imageURl;
			bean.productCode = productCode;
			bean.qty = quantity;


			list.Add (bean);
		}
		void saveSearchAction (Object sender, EventArgs EventArgs)
		{
			Debug.WriteLine ("saveSearchAction");
		}
		void sortResultsBylayoutAction (Object sender, EventArgs EventArgs)
		{
			Debug.WriteLine ("sortResultsBylayoutAction");
		}
		void searchOperationPerformed (Object sender, EventArgs EventArgs)
		{
			Debug.WriteLine ("searchOperationPerformed");
		}

		protected override async void OnAppearing ()
		{

		}
		void addToCartClicked (Object sender, EventArgs EventArgs)
		{
			Debug.WriteLine ("addToCartClicked");

		}
		void saveSearchSave (Object sender, EventArgs EventArgs)
		{
			Debug.WriteLine ("saveSearchSave");
		}

		void saveSearch ()
		{
			Debug.WriteLine ("saveSearch");
		}




		void closeSaveSearch (Object sender, EventArgs EventArgs)
		{
			Debug.WriteLine ("closeSaveSearch");
		}

		void downloadActionGesture (Object sender, EventArgs EventArgs)
		{
			Debug.WriteLine ("Download Action");
		}

		void customlisttapped (Object sender, EventArgs EventArgs)
		{
			var b = (ListView)sender;
			var t = b.SelectedItem;
			SearchResultUIBean item = (SearchResultUIBean)t;
			//Debug.WriteLine (item.promoSource);
		}

		void onSettingsAction (object sender, EventArgs e)
		{
			Debug.WriteLine ("onSettingsAction");
			//this.Navigation.PushAsync (new ContactUs ());

		}
		void onSaveAction (Object sender, EventArgs EventArgs)
		{
			Debug.WriteLine ("onSaveAction");
		}

	}
}



