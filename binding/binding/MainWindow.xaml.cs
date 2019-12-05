
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;


namespace binding
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    /// 

    // credit https://youtu.be/TA1eChovYEU

    public partial class MainWindow : Window
    {
       internal static Store store = new Store();
       

        public MainWindow()
        {
            InitializeComponent();
        }

        //List type click 

        private void OnSelected(object sender, SelectionChangedEventArgs e)
        {
           

          if((sender as ListBox). SelectedItem !=null)
            {
                string foodtype = ((sender as ListBox).SelectedItem as ListBoxItem).Content.ToString();

                DataContext = from item in store.Inventory
                              where item.type.ToString() == foodtype
                              select item;
            }

           
        }

        // List click, 하단리스트박스 (메뉴) 선택
        private void OnSelected2(object sender, SelectionChangedEventArgs e)
        {
            var item = (Item)mylistBox2.SelectedItem;
            MessageBox.Show("$" + item.price);
            

        }




        ////listBox-Refresh for Add items?
        //public delegate void RefreshList(FoodType foodType);
        //public event RefreshList RefreshListEvent;



    }
}
