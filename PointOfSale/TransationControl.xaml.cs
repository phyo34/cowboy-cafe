﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CashRegister;
using CowboyCafe.Data;
using Extensions;


namespace PointOfSale
{


    /// <summary>
    /// Interaction logic for TransationControl.xaml
    /// </summary>
    public partial class TransationControl : UserControl
    {

        public CashDrawer cashDrawer = new CashDrawer();

        public TransationControl()
        {
            InitializeComponent();
        }


        private void OnCreditClick(object sender, RoutedEventArgs e)
        {

            var cardTerminal = new CardTerminal(); //New card terminal
             ResultCode result = cardTerminal.ProcessTransaction((this.DataContext as Order).TotalCost);

            switch (result)
            {
                case ResultCode.Success:
                    PrintReceiptForTransaction((this.DataContext as Order).TotalCost,0, "Card");
                    var control = this.FindAncestor<OrderControl>();
                    control.DataContext = new Order();
                    control.CompleteT.Visibility = Visibility.Visible;
                    control.Container.Child = new MenuItemSelectionControl();
                    break;
            }
        }

        private void OnCashClick(object sender, RoutedEventArgs e)
        {
            var screen = new CashControl();
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl?.SwapScreen(screen);
        }

        private void PrintReceiptForTransaction(double amountpaid, double returnedamount, string paymenttype)
        {
            var recieptPrinter = new ReceiptPrinter();
            var order = this.DataContext as Order;

            string text = "";


            DateTime date = DateTime.Now;
            uint orderNum = order.OrderNumber - 1;


            text = "\nOrder Number: " + orderNum + "\n Date: " + date;

            foreach (var item in order.Items)
            {
                text += "\n" + item.ToString() + " Price: " + item.Price;
            }

            if (paymenttype == "Card")
            {
                text += "\n Card Charged: " + amountpaid;
            }
            else
            {
                text += "\n Cash Given: " + amountpaid;
                text += "\n Cash Returned: " + returnedamount;
            }

            recieptPrinter.Print(text);

        }

        public void CashPayment(double paid, double due)
        {

            double returned = paid - due;
            bool dollarCoin = false;

            int ret_hun = (int)returned / 100;
            int ret_fifty = (int)(returned % 100) / 50;
            int ret_twent = (int)((returned % 50) % 100) / 20;
            int ret_ten = (int)(((returned % 20) % 50) % 100) / 10;
            int ret_five = (int)((((returned % 10) % 20) % 50) % 100) / 5;
            int ret_two = (int)(((((returned % 5) % 10) % 20) % 50) % 100) / 2;
            int ret_one = (int)((((((returned % 2) % 5) % 10) % 20) % 50) % 100);
            int ret_haldol = (int)(((((((returned % 1) % 2) % 5) % 10) % 20) % 50 % 100) / .5);
            int ret_quart = (int)(((((((((returned % .5) % 1) % 2) % 5) % 10) % 20) % 50) % 100) / .25);
            int ret_dime = (int)((((((((((returned % .25) % .5) % 1) % 2) % 5) % 10) % 20) % 50) % 100) / .1);
            int ret_nik = (int)(((((((((((returned % .1) % .25) % .5) % 1) % 2) % 5) % 10) % 20) % 50) % 100) / .05);
            int ret_pen = (int)((((((((((((returned % .05) % .1) % .25) % .5) % 1) % 2) % 5) % 10) % 20) % 50) % 100) / .01);

            if (ret_hun > cashDrawer.Hundreds)
            {
                for (int i = 0; i <= ret_hun; i++)
                {
                    ret_fifty = ret_fifty + 2;
                }
            }

            if (ret_fifty > cashDrawer.Fifties)
            {
                for (int i = 0; i <= ret_fifty; i++)
                {
                    ret_twent = ret_twent + 2;
                    ret_ten = ret_ten + 1;
                }
            }

            if (ret_twent > cashDrawer.Twenties)
            {
                for (int i = 0; i <= ret_twent; i++)
                {
                    ret_ten = ret_ten + 2;
                }
            }

            if (ret_ten > cashDrawer.Tens)
            {
                for (int i = 0; i <= ret_ten; i++)
                {
                    ret_five = ret_five + 2;

                }
            }

            if (ret_five > cashDrawer.Fives)
            {
                for (int i = 0; i <= ret_five; i++)
                {
                    ret_two = ret_two + 2;
                    ret_one = ret_one + 1;
                }
            }

            if (ret_one > cashDrawer.Ones)
            {
                dollarCoin = true;
                if (ret_one > cashDrawer.Dollars)
                {
                    for (int i = 0; i <= ret_one; i++)
                    {
                        ret_haldol = ret_haldol + 2;

                    }
                }
            }

            if (ret_haldol > cashDrawer.HalfDollars)
            {
                for (int i = 0; i <= ret_haldol; i++)
                {
                    ret_quart = ret_quart + 2;
                }
            }

            if (ret_quart > cashDrawer.Quarters)
            {
                for (int i = 0; i <= ret_quart; i++)
                {
                    ret_dime = ret_dime + 2;
                    ret_nik = ret_nik + 1;

                }
            }

            if (ret_dime > cashDrawer.Dimes)
            {
                for (int i = 0; i <= ret_dime; i++)
                {
                    ret_nik = ret_nik + 2;
                }
            }

            if (ret_nik > cashDrawer.Nickels)
            {
                for (int i = 0; i <= ret_nik; i++)
                {
                    ret_pen = ret_pen + 5;
                }
            }

            string text = "Cash to return: \n";

            if (ret_hun > 0) text += "Hundreds: " + ret_hun;

            if (ret_fifty > 0) text += "\nFifties: " + ret_fifty;

            if (ret_twent > 0) text += "\nTwenties: " + ret_twent;

            if (ret_ten > 0) text += "\nTens: " + ret_ten;

            if (ret_five > 0) text += "\nFives: " + ret_five;

            if (ret_two > 0) text += "\nTwos: " + ret_two;

            if (ret_one > 0)
            {
                if (dollarCoin) text += "\nDollar Coins: " + ret_one;
                else text += "\nOne Dollars: " + ret_one;
            }

            if (ret_haldol > 0) text += "\nHalf-Dollars: " + ret_haldol;

            if (ret_quart > 0) text += "\nQuarters: " + ret_quart;

            if (ret_dime > 0) text += "\nDimes: " + ret_dime;

            if (ret_nik > 0) text += "\nNikels: " + ret_nik;

            if (ret_pen > 0) text += "\nPennies: " + ret_pen;

            MessageBox.Show(text);

            PrintReceiptForTransaction(paid, returned, "case");
        }
    }
}
