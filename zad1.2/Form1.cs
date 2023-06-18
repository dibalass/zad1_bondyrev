using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace zad1_bondyrev
{
    public partial class Form1 : Form
    {
        List<Shop> list_of_shops = new List<Shop>();
        Shop currient_shop;
        int index;
        public Form1()
        {
            InitializeComponent();
        }
        private bool checkMarket()
        {
            if (currient_shop == null)
            {
                MessageBox.Show("Вы не выбрали магазин");
                return false;
            }
            return true;
        }
        private bool checkStuff()
        {
            try
            {
                decimal price = Convert.ToDecimal(price_add.Text);
                int count = int.Parse(count_add.Text);
                if (name_add.Text.Length == 0)
                {
                    MessageBox.Show("Введи название товара");
                    return false;
                }
                if (price <= 0)
                {
                    MessageBox.Show("Цена должна быть больше 0");
                    return false;
                }
                if (count <= 0)
                {
                    MessageBox.Show("Количество товара должно быть больше 0");
                    return false;
                }
                return true;
            }
            catch
            {
                MessageBox.Show("Вы ввели не число");
                return false;
            }
        }
        private void refresh(int index)
        {
            currient_shop = list_of_shops[index];
            profit_market.Text = $"Прибыль магазина: {currient_shop.getProfit} рублей";
            currient_shop.showAllProducts(products);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkStuff() && checkMarket())
            {
                if (currient_shop.FindByName(name_add.Text) == null)
                {
                    currient_shop.CreateProduct(name_add.Text, Convert.ToDecimal(price_add.Text), int.Parse(count_add.Text));
                    refresh(index);
                    MessageBox.Show("Вы добавили товар");
                }
                else
                    MessageBox.Show("Такой товар уже есть");
            }
        }
        private bool checkName(string name)
        {
            if (name.Length == 0)
            {
                MessageBox.Show("Введи название магазина");
                return false;
            }

            foreach (char i in name)
            {
                if (!Char.IsLetterOrDigit(i))
                {
                    MessageBox.Show("Название магазина может содержать только буквы и цифры");
                    return false;
                }
            }
            return true;
        }
        private void addInList()
        {
            list_of_shops.Add(new Shop(market_add.Text));
            choose_market.Items.Add(list_of_shops[list_of_shops.Count - 1].getName);
        }
        List<string> list_market = new List<string>();
        private void addMarketButton_Click(object sender, EventArgs e)
        {
            if (checkName(market_add.Text))
            {
                if (!list_market.Contains(market_add.Text))
                {
                    addInList();
                    list_market.Add(market_add.Text);
                    MessageBox.Show("Вы добавили магазин");
                }
                else
                    MessageBox.Show("Такой магазин уже есть");
            }
        }

        private void buyButton_Click_1(object sender, EventArgs e)
        {
            if (checkMarket())
            {
                currient_shop.Sell(name_buy.Text, int.Parse(count_buy.Value.ToString()));
                refresh(index);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = choose_market.SelectedIndex;
            refresh(index);
        }




        //код 2 задания



        int currient_track_index = 0;
        Playlist playlist = new Playlist();
        SoundPlayer player = new SoundPlayer();
        private void deleteCurrientTrackButton_Click(object sender, EventArgs e)
        {
            try
            {
                player.Stop();
                playlist.DeleteTrack(currient_track_index);
                UpdateCountOfTracks();
                player.SoundLocation = playlist.GetTrack(currient_track_index);
                player.Play();
                Start_Stop.Text = "⏸";
                currientTrack.Text = playlist.GetTitle(currient_track_index);

            }
            catch (Exception ex)
            {
                if (playlist.CountOfTracks == 0)
                {
                    currientTrack.Text = "";
                    MessageBox.Show("У вас нет треков в плейлисте");
                }
                else
                {
                    player.SoundLocation = playlist.GetTrack(playlist.CountOfTracks - 1);
                    player.Play();
                    Start_Stop.Text = "⏸";
                    currientTrack.Text = playlist.GetTitle(playlist.CountOfTracks - 1);
                }
            }
        }

        private void deleteTrackOnIndexButton_Click(object sender, EventArgs e)
        {
            try
            {
                player.Stop();
                playlist.DeleteTrack(int.Parse(index_track.Value.ToString()));
                UpdateCountOfTracks();
                player.SoundLocation = playlist.GetTrack(int.Parse(index_track.Value.ToString()));
                player.Play();
                Start_Stop.Text = "⏸";
                currientTrack.Text = playlist.GetTitle(int.Parse(index_track.Value.ToString()));

            }
            catch (Exception ex)
            {
                if (playlist.CountOfTracks == 0)
                {
                    currientTrack.Text = "";
                    MessageBox.Show("У вас нет треков в плейлисте");
                }
                else
                {
                    player.SoundLocation = playlist.GetTrack(playlist.CountOfTracks - 1);
                    player.Play();
                    Start_Stop.Text = "⏸";
                    currientTrack.Text = playlist.GetTitle(playlist.CountOfTracks - 1);
                }
            }
        }

        private void startTrackOnIndexButton_Click(object sender, EventArgs e)
        {
            if (playlist.CountOfTracks == 0)
            {
                MessageBox.Show("У вас нет треков в плейлисте");
            }
            else
            {

                player.Stop();
                currient_track_index++;
                player.SoundLocation = playlist.GetTrack(int.Parse(index_track.Value.ToString()));
                player.Play();
                Start_Stop.Text = "⏸";
                currientTrack.Text = playlist.GetTitle(int.Parse(index_track.Value.ToString()));
                currient_track_index = int.Parse(index_track.Value.ToString());


            }
        }

        private void firstTrackButton_Click(object sender, EventArgs e)
        {
            if (playlist.CountOfTracks == 0)
            {
                currientTrack.Text = "";
                MessageBox.Show("У вас нет треков в плейлисте");
            }
            else
            {
                player.SoundLocation = playlist.GetTrack(0);
                player.Play();
                Start_Stop.Text = "⏸";
                currientTrack.Text = playlist.GetTitle(0);
            }
        }
        public void UpdateCountOfTracks()
        {
            if (playlist.CountOfTracks > 1)
                index_track.Maximum = playlist.CountOfTracks - 1;
            else
                index_track.Maximum = 0;
        }
        private void clearPlayListButton_Click(object sender, EventArgs e)
        {
            player.Stop();
            playlist.ClearPlayList();
            UpdateCountOfTracks();
            Start_Stop.Text = "⏯️";
            currient_track_index = 0;
            currientTrack.Text = "";
        }

        private void stopAndStartButton_Click(object sender, EventArgs e)
        {
            if (Start_Stop.Text == "⏸")
            {
                if (playlist.CountOfTracks == 0)
                {
                    MessageBox.Show("У вас нет треков в плейлисте");
                }
                else
                {
                    player.Stop();
                    Start_Stop.Text = "⏯️";
                }

            }
            else if (Start_Stop.Text == "⏯️")
            {
                if (playlist.CountOfTracks == 0)
                {
                    MessageBox.Show("У вас нет треков в плейлисте");
                }
                else
                {
                    player.Stop();
                    player.SoundLocation = playlist.GetTrack(currient_track_index);
                    player.Play();
                    currientTrack.Text = playlist.GetTitle(currient_track_index);
                    Start_Stop.Text = "⏸";
                }

            }
        }

        private void previousTrackButton_Click(object sender, EventArgs e)
        {
            if (playlist.CountOfTracks == 0)
            {
                MessageBox.Show("У вас нет треков в плейлисте");
            }
            else
            {
                if (currient_track_index > 0)
                {
                    currient_track_index--;
                    player.SoundLocation = playlist.GetTrack(currient_track_index);
                    player.Play();
                    currientTrack.Text = playlist.GetTitle(currient_track_index);
                    Start_Stop.Text = "⏸";
                }
            }
        }

        private void nextTrackButton_Click(object sender, EventArgs e)
        {
            if (playlist.CountOfTracks == 0)
            {
                MessageBox.Show("У вас нет треков в плейлисте");
            }
            else
            {
                if (currient_track_index < playlist.CountOfTracks - 1)
                {
                    player.Stop();
                    currient_track_index++;
                    player.SoundLocation = playlist.GetTrack(currient_track_index);
                    player.Play();
                    currientTrack.Text = playlist.GetTitle(currient_track_index);
                    Start_Stop.Text = "⏸";
                }
            }
        }
        public bool checkTrack()
        {
            if (track.Text.Length == 0)
            {
                MessageBox.Show("Введи название трека");
                return false;
            }
            if (author.Text.Length == 0)
            {
                MessageBox.Show("Введи автора трека");
                return false;
            }
            if (file.Text.Length == 0)
            {
                MessageBox.Show("Введи название файла");
                return false;
            }
            if (!File.Exists(file.Text))
            {
                MessageBox.Show("Такого файла нет");
                return false;
            }
            return true;
        }
        List<string> list_track = new List<string>();
        private void addTrackButton_Click(object sender, EventArgs e)
        {
            if (checkTrack())
            {
                if (!list_track.Contains(file.Text))
                {
                    playlist.Add(author.Text, track.Text, file.Text);
                    UpdateCountOfTracks();
                    list_track.Add(file.Text);
                    MessageBox.Show("Трек добавлен");
                }
                else
                    MessageBox.Show("Такой трек уже есть");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
