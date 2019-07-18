using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
namespace SloppyJoe
{
    class MenuMaker : INotifyPropertyChanged
    {
        private Random random = new Random();
        private List<String> meats = new List<String>()
 { "Roast beef", "Salami", "Turkey", "Ham", "Pastrami" };
        private List<String> condiments = new List<String>() { "yellow mustard",
 "brown mustard", "honey mustard", "mayo", "relish", "french dressing" };
        private List<String> breads = new List<String>() { "rye", "white", "wheat",
 "pumpernickel", "italian bread", "a roll" };

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<MenuItem> Menu { get; private set; }

        public DateTime GeneratedDate { get; set; }

        public int NumberOfItems { get; set; }

        public void OnPropertChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChangedEvent = PropertyChanged;

            if(propertyChangedEvent!=null)
            {
                propertyChangedEvent(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void UpdateMenu()
        {
            Menu.Clear();
            for(int i=0; i<NumberOfItems; i++)
            {
                Menu.Add(CreateMenuItem());
            }
            GeneratedDate = DateTime.Now;

            OnPropertChanged("GeneratedDate");
        }
        public MenuItem CreateMenuItem()
        {
            string randomMeat = meats[random.Next(meats.Count)];
            string randomCondiments = condiments[random.Next(meats.Count)];
            string randomBread = breads[random.Next(meats.Count)];
            return new MenuItem(randomMeat, randomCondiments, randomBread);
        }

        public MenuMaker()
        {
            Menu = new ObservableCollection<MenuItem>();
            NumberOfItems = 10;
            UpdateMenu();
        }
    }

    class MenuItem
    {
        public string Meat { get; set; }
        public string Condiment { get; set; }
        public string Bread { get; set; }
        public MenuItem(string meat, string condiment, string bread)
        {
            Meat = meat;
            Condiment = condiment;
            Bread = bread;
        }
        public override string ToString()
        {
            return Meat + " with " + Condiment + " on " + Bread;
        }
    }
}

/*
 *     <Grid Margin="5">
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="Auto"/>
        </Grid.RowDefinitions>
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="Auto"/>
            <ColumnDefinition Width="Auto"/>
        </Grid.ColumnDefinitions>
        <StackPanel Grid.Row="1">
            <StackPanel Orientation="Horizontal">
                <StackPanel>
                    <TextBlock Text="Number of Items"/>
                    <TextBox Text="{Binding NumberOfItems, Mode=TwoWay}"/>
                </StackPanel>
                <Button x:Name="newMenu" Content="Make a new menu"/>
            </StackPanel>
            <ListView ItemsSource="{Binding Menu}"/>
            <TextBlock>
            <Run/>
            <Run Text="{Binding GeneratedData}"/>
            </TextBlock>
        </StackPanel>
    </Grid>
*/