using System.Net.Http.Json;
using System.Runtime.InteropServices.Marshalling;

namespace Albion_Calcu_C3
{
	public partial class UserControl1 : UserControl
	{
		
		//user variables
		private Form1 _parentForm;

		//dictionaries
		private Dictionary<string, (NumericUpDown Resource, NumericUpDown Product, Label Silver_profit, Label Percent_profit, Label Focus_cost, Label Focus_profit, Label Fp_Fc)> Prices_obj = new();
		
        private record class Item_Properties
        {
            public string? item_id { get; set; }
            public string? city { get; set; }
            public int? quality { get; set; }
            public int? sell_price_min { get; set; }
            public string? sell_price_min_date { get; set; }
            public int? sell_price_max { get; set; }
            public string? sell_price_max_date { get; set; }
            public int? buy_price_min { get; set; }
            public string? buy_price_min_date { get; set; }
            public int? buy_price_max { get; set; }
            public string? buy_price_max_date { get; set; }
        };

        private static HttpClient sharedClient = new()
		{
			BaseAddress = new Uri("https://east.albion-online-data.com")
		};

        

        private void stealfocus_UserControl1() => label19.Focus();

		private int Get_multiplier(int tier)
		{
			if (tier == 2)
			{
				return 1;
			}

			if (tier == 3 || tier == 4)
			{

				return 2;
			}

			if (tier == 5)
			{
				return 3;
			}

			if (tier == 6)
			{
				return 4;
			}

			if (tier == 7 || tier == 8)
			{
				return 5;
			}


			return 3;
		}
		private void Compute_Profit(NumericUpDown Price_Res, NumericUpDown Price_prod_revenue, NumericUpDown Price_Prod, Label Silver_profit, Label Percent_profit, Label Focus_cost, Label Focus_profit, Label Fp_Fc, int Tier, int Enchant)
		{

			float ref_Amount = _parentForm.Get_Amount();
			int ref_cost = (int)(ref_Amount) * (int)Price_Prod.Value;

			float raw_Amount = ref_Amount * Get_multiplier(Tier);
			int raw_cost = (int)raw_Amount * (int)Price_Res.Value;

			float rrr = (float)Math.Round(_parentForm.Get_rrr(), 4);

			int Quantity = (int)ref_Amount;
			float Revenue = 0;
			float Profit = 0;
			float Profit_percent = 0;
            float Material_cost = 0;

			float UsageFee = _parentForm.Get_UsageFee();
			float Usage_Fee_per_Nutri = UsageFee / 100;
			int UsageFee_cost = 0;

			const float Factor = 0.1125f;
			int Item_Value = (int)(16.0 * (Math.Pow(2, Tier + Enchant - 4)));
			float Consumption = (float)Item_Value * Factor;

			float SetupFee = 0.025f;
			float TaxFee = 0.08f;

			while ((int)(ref_Amount) != 0)
			{
				ref_Amount *= rrr;

				Quantity += (int)(Math.Round(ref_Amount));
				if (Tier != 2)
				{
					UsageFee_cost += (int)Math.Round(Usage_Fee_per_Nutri * Consumption * ref_Amount);
				}


			}
			

            if (Tier == 2)
			{
				ref_cost = 0;
			}

			Revenue = ((float)Quantity * (float)Price_prod_revenue.Value) * (1 - (SetupFee + TaxFee));

			Material_cost = UsageFee_cost + ref_cost + raw_cost;
			
			Profit = Revenue - Material_cost;
			Profit_percent = (Profit / Material_cost) * 100;

			if(float.IsNaN(Profit_percent) || float.IsInfinity(Profit_percent))
			{
				Profit_percent = 0.0f;
            }
            //display
            try
			{
                Silver_profit.Text = $"{Profit:n0}";
                Percent_profit.Text = $"{(Profit_percent).ToString("0.00"):n2}";
            }	catch
			{

			}
            

			//richTextBox1.Text +=
			//($"Price_res:{Price_Res.Name}\n" +
			//$"Price_prod_revenue:{Price_prod_revenue.Name}\n" +
			//$"Price_prod:{Price_Prod.Name}\n" +
			//$"Quantity:{Quantity}\n" +
			//$"Amount:{ref_Amount}\n" +
			//$"rrr:{rrr}" +
			//$"\nFee:{UsageFee_cost}" +
			//$"\nRevenue:{Math.Round(Revenue, 0)}" +
			//$"\nMatCost:{Math.Round(Material_cost, 0)}" +
			//$"\nProfit:{Math.Round(Profit, 0)}\n\n");


		}
		private void get_zeroes(NumericUpDown num)
		{
			if (num.Text == "")
			{
				num.Text = "0";
			}
		}
		private void input_3(Decimal Tkey_value)
		{


			//MessageBox.Show($"Resource:{Resource.Name}\nProduct:{Product.Name}");




			Decimal Tkey_product = 4.0m;
			for (Decimal i = 0.1m; i <= 0.4m; i += 0.1m)
			{

				Decimal Tkey_product_temp = Tkey_product + i;
				string Tkey_product_string = Tkey_product_temp.ToString("0.0");

				NumericUpDown Resource = Prices_obj[Tkey_product_string].Resource;
				NumericUpDown Product = Prices_obj[Tkey_value.ToString("0.0")].Product;
				NumericUpDown Product_revenue = Prices_obj[Tkey_product_string].Product;

				Label Profit_silver = Prices_obj[Tkey_product_string].Silver_profit;
				Label Profit_percent = Prices_obj[Tkey_product_string].Percent_profit;
				Label Focus_cost = Prices_obj[Tkey_product_string].Focus_cost;
				Label Focus_profit = Prices_obj[Tkey_product_string].Focus_profit;
				Label Fp_Fc = Prices_obj[Tkey_product_string].Fp_Fc;

				Compute_Profit(Resource, Product_revenue, Product, Profit_silver, Profit_percent, Focus_cost, Focus_profit, Fp_Fc, Convert.ToInt16(Tkey_product), Convert.ToInt16(i * 10.0m));
			}

		}
		private void lblTextChanged(object sender, EventArgs e)
		{
			Label txt = (Label)sender;


			try
			{
				Decimal txt_value = Convert.ToDecimal(txt.Text);

				if (txt_value < 0)
				{
					txt.ForeColor = Color.Red;
				}
				if (txt_value > 0)
				{
					txt.ForeColor = Color.Green;
				}
			}
			catch(Exception ex) 
			{
				MessageBox.Show(ex.ToString());
			}


		}
		
		private string Get_Tkey(string[] item_split)
		{
			string key = "";

			if(item_split.Length != 3)
			{
                for (int i = 2; i <= 8; i++)
                {
                    if (item_split[0].Contains(i.ToString()))
                    {
                        return key = i.ToString()+".0";
                    }
                }
            }


			for(int i = 4;i<=8;i++)
			{
				if (item_split[0].Contains(i.ToString()))
				{
					key = i.ToString();
				}
			}

            for (int i = 1; i <= 4; i++)
            {
                if (item_split[2].Contains(i.ToString()))
                {
                    return key += "."+i.ToString();
                }
            }


			return key;
            
		}
		private void Populate_nums(List<Item_Properties> fetched_data)
		{
			string string_data = "";
			foreach(var data in fetched_data)
			{
				string_data += data.ToString();
				string Tkey;
				string? data_item_ID = data.item_id;

                
                if (data_item_ID != null)
				{
                    string[] item_split = data_item_ID.Split("_");

                    Tkey = Get_Tkey(item_split);


					NumericUpDown? what_num = null;

					if (_parentForm.cmbType.SelectedItem?.ToString() == "Raw")
					{
						what_num = Prices_obj[Tkey].Resource;
					}

					if (_parentForm.cmbType.SelectedItem?.ToString() == "Refined")
					{
						what_num = Prices_obj[Tkey].Product;
					}

					if (_parentForm.cmbOrder.Text == "Sell-Order")
					{
						what_num?.Text = data.sell_price_min.ToString();
					}

					if (_parentForm.cmbOrder.Text == "Buy-Order")
					{
						what_num?.Text = data.buy_price_max.ToString();
					}

					

				}

			}

			MessageBox.Show(string_data);
		}
		private async void Get_API_Data(string loc, string id, CheckedListBox check)
		{
            List<Item_Properties>? fetched_data = null;

            try
			{
				
				string url = $"/api/v2/stats/prices/{id}.json?locations={loc}&qualities=1";
				fetched_data = await sharedClient.GetFromJsonAsync<List<Item_Properties>>(url);
				

				if (fetched_data != null)
				{

					MessageBox.Show("Data Prices Pulled Successfuly");

					Populate_nums(fetched_data);

				}
				

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
            }		
		}
		private void Load_defaults()
		{
            //EVENT load
            _parentForm.btnPull.Click += btn_pull_clicked;
			_parentForm.get_numAmount().ValueChanged += numparent_ValueChanged;
            _parentForm.get_numUsageFee().ValueChanged += numparent_ValueChanged;
            //populate the dictionary
            Prices_obj["2.0"] = (numResource20, numProduct20, lblProfitS20, lblProfitP20, lblFocusC20, lblFocusP20, lblFocusFPFC20);

			Prices_obj["3.0"] = (numResource30, numProduct30, lblProfitS30, lblProfitP30, lblFocusC30, lblFocusP30, lblFocusFPFC30);

			Prices_obj["4.0"] = (numResource40, numProduct40, lblProfitS40, lblProfitP40, lblFocusC40, lblFocusP40, lblFocusFPFC40);
			Prices_obj["4.1"] = (numResource41, numProduct41, lblProfitS41, lblProfitP41, lblFocusC41, lblFocusP41, lblFocusFPFC41);
			Prices_obj["4.2"] = (numResource42, numProduct42, lblProfitS42, lblProfitP42, lblFocusC42, lblFocusP42, lblFocusFPFC42);
			Prices_obj["4.3"] = (numResource43, numProduct43, lblProfitS43, lblProfitP43, lblFocusC43, lblFocusP43, lblFocusFPFC43);
			Prices_obj["4.4"] = (numResource44, numProduct44, lblProfitS44, lblProfitP44, lblFocusC44, lblFocusP44, lblFocusFPFC44);

			Prices_obj["5.0"] = (numResource50, numProduct50, lblProfitS50, lblProfitP50, lblFocusC50, lblFocusP50, lblFocusFPFC50);
			Prices_obj["5.1"] = (numResource51, numProduct51, lblProfitS51, lblProfitP51, lblFocusC51, lblFocusP51, lblFocusFPFC51);
			Prices_obj["5.2"] = (numResource52, numProduct52, lblProfitS52, lblProfitP52, lblFocusC52, lblFocusP52, lblFocusFPFC52);
			Prices_obj["5.3"] = (numResource53, numProduct53, lblProfitS53, lblProfitP53, lblFocusC53, lblFocusP53, lblFocusFPFC53);
			Prices_obj["5.4"] = (numResource54, numProduct54, lblProfitS54, lblProfitP54, lblFocusC54, lblFocusP54, lblFocusFPFC54);

			Prices_obj["6.0"] = (numResource60, numProduct60, lblProfitS60, lblProfitP60, lblFocusC60, lblFocusP60, lblFocusFPFC60);
			Prices_obj["6.1"] = (numResource61, numProduct61, lblProfitS61, lblProfitP61, lblFocusC61, lblFocusP61, lblFocusFPFC61);
			Prices_obj["6.2"] = (numResource62, numProduct62, lblProfitS62, lblProfitP62, lblFocusC62, lblFocusP62, lblFocusFPFC62);
			Prices_obj["6.3"] = (numResource63, numProduct63, lblProfitS63, lblProfitP63, lblFocusC63, lblFocusP63, lblFocusFPFC63);
			Prices_obj["6.4"] = (numResource64, numProduct64, lblProfitS64, lblProfitP64, lblFocusC64, lblFocusP64, lblFocusFPFC64);

			Prices_obj["7.0"] = (numResource70, numProduct70, lblProfitS70, lblProfitP70, lblFocusC70, lblFocusP70, lblFocusFPFC70);
			Prices_obj["7.1"] = (numResource71, numProduct71, lblProfitS71, lblProfitP71, lblFocusC71, lblFocusP71, lblFocusFPFC71);
			Prices_obj["7.2"] = (numResource72, numProduct72, lblProfitS72, lblProfitP72, lblFocusC72, lblFocusP72, lblFocusFPFC72);
			Prices_obj["7.3"] = (numResource73, numProduct73, lblProfitS73, lblProfitP73, lblFocusC73, lblFocusP73, lblFocusFPFC73);
			Prices_obj["7.4"] = (numResource74, numProduct74, lblProfitS74, lblProfitP74, lblFocusC74, lblFocusP74, lblFocusFPFC74);

			Prices_obj["8.0"] = (numResource80, numProduct80, lblProfitS80, lblProfitP80, lblFocusC80, lblFocusP80, lblFocusFPFC80);
			Prices_obj["8.1"] = (numResource81, numProduct81, lblProfitS81, lblProfitP81, lblFocusC81, lblFocusP81, lblFocusFPFC81);
			Prices_obj["8.2"] = (numResource82, numProduct82, lblProfitS82, lblProfitP82, lblFocusC82, lblFocusP82, lblFocusFPFC82);
			Prices_obj["8.3"] = (numResource83, numProduct83, lblProfitS83, lblProfitP83, lblFocusC83, lblFocusP83, lblFocusFPFC83);
			Prices_obj["8.4"] = (numResource84, numProduct84, lblProfitS84, lblProfitP84, lblFocusC84, lblFocusP84, lblFocusFPFC84);
		}

        private string Get_Type()
        {
            if (_parentForm.cmbType.Text == "Raw")
            {
                switch (_parentForm.cmbChooseResource.SelectedIndex)
                {
                    case 0:
                        return "ORE";
                    case 1:
                        return "CLOTH";
                    case 2:
                        return "HIDE";
                    case 3:
                        return "ROCK";
                    case 4:
                        return "WOOD";

                }
            }

            if (_parentForm.cmbType.Text == "Refined")
            {
                switch (_parentForm.cmbChooseResource.SelectedIndex)
                {
                    case 0:
                        return "METALBAR";

                    case 1:
                        return "FIBER";
                    case 2:
                        return "LEATHER";
                    case 3:
                        return "STONEBLOCK";
                    case 4:
                        return "PLANKS";

                }
            }
            return "";
        }


        public UserControl1(Form1 parentForm)
		{
			InitializeComponent();
            _parentForm = parentForm;
        }
        

        //EVENTS
        private void UserControl1_Load(object sender, EventArgs e)
		{
			Load_defaults();
			
		}

		private void btn_pull_clicked(object? sender, EventArgs e)
		{
            string location_pull;
            string item_ID_pull;
            CheckedListBox check = _parentForm.checkTier;

            item_ID_pull = "";
            location_pull = _parentForm.cmbPull_Location.Text;
            for (int i = 0; i < check.CheckedItems.Count; i++)
            {

                string[]? split = (check.CheckedItems[i]?.ToString())?.Split('.');
                item_ID_pull += $"T{split?[0]}_{Get_Type()}";

                if (Convert.ToInt16(split?[1]) > 0)
                {
                    item_ID_pull += $"_LEVEL{split?[1]}@{split?[1]}";
                }

                if (i < check.CheckedItems.Count - 1)
                {
                    item_ID_pull += ",";
                }
               
            }

            Get_API_Data(location_pull,item_ID_pull,check);




        }

		private void numparent_ValueChanged(object? sender, EventArgs e)
		{
			
			foreach(var dic in Prices_obj)
			{
                ValueChanged_Product(dic.Value.Product,e);
			}

		}

        private void numValidated(object sender, EventArgs e)
		{
			NumericUpDown numupdown = (NumericUpDown)sender;

			//populate the textbox with 0 by default
			get_zeroes(numupdown);
        }


		private void numEnter(object sender, EventArgs e)
		{

			NumericUpDown num_Enter = (NumericUpDown)sender;

			num_Enter.BackColor = Color.IndianRed;
		}

		private void numLeave(object sender, EventArgs e)
		{
			NumericUpDown num_Leave = (NumericUpDown)sender;
			num_Leave.BackColor = Color.DarkGray;


		}

		private void numKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Escape)
			{
				stealfocus_UserControl1();
			}
		}

		private void numValueChanged_Resource(object sender, EventArgs e)
		{


			NumericUpDown Numobj = (NumericUpDown)sender;

			string? Tkey = Numobj.Tag?.ToString();
			Decimal Tkey_value = Convert.ToDecimal(Tkey);

			//MessageBox.Show(Tkey_value.ToString());

			if (Tkey != null)
			{
				string Tkey_product = (Tkey_value - 1).ToString("0.0");


				Int16 tier = Convert.ToInt16(Convert.ToDecimal(Tkey));
				Int16 enchant = Convert.ToInt16((Convert.ToDecimal(Tkey) - tier) * 10);

				if (Tkey_value == 2.0m)
				{
					Tkey_product = "2.0";
				}

				if (Tkey_value >= 4.0m && Tkey_value <= 4.4m)
				{
					Tkey_product = "3.0";
				}


				NumericUpDown Resource = Prices_obj[Tkey].Resource;
				NumericUpDown Product_revenue = Prices_obj[Tkey].Product;
				NumericUpDown Product = Prices_obj[Tkey_product].Product;

				//MessageBox.Show($"Resource:{Resource.Name}\nProduct:{Product.Name}");

				Label Profit_silver = Prices_obj[Tkey].Silver_profit;
				Label Profit_percent = Prices_obj[Tkey].Percent_profit;
				Label Focus_cost = Prices_obj[Tkey].Focus_cost;
				Label Focus_profit = Prices_obj[Tkey].Focus_profit;
				Label Fp_Fc = Prices_obj[Tkey].Fp_Fc;

				Compute_Profit(Resource, Product_revenue, Product, Profit_silver, Profit_percent, Focus_cost, Focus_profit, Fp_Fc, tier, enchant);


			}
		}

		private void ValueChanged_Product(object sender, EventArgs e)
		{
			NumericUpDown numobj = (NumericUpDown)sender;

			string? Tkey = numobj.Tag?.ToString();
			Decimal Tkey_value = Convert.ToDecimal(Tkey);

			//MessageBox.Show(Tkey_value.ToString());

			if (Tkey != null)
			{
				string Tkey_product = Tkey;

                if (Tkey_value < 8.0m )
				{
                    Tkey_product = (Tkey_value + 1).ToString("0.0");
                }
				
				//TODO: what to do if they input in product(3.0)
				Int16 tier = Convert.ToInt16(Convert.ToDecimal(Tkey));
				Int16 enchant = Convert.ToInt16((Convert.ToDecimal(Tkey) - tier) * 10);

				if (Tkey == "3.0")
				{
					input_3(Tkey_value);
				}else
                {

					if (tier == 2)
					{
						tier = 3;
					}

					//MessageBox.Show($"Tier:{tier}\nEnchant:{enchant}");
                

					NumericUpDown Resource = Prices_obj[Tkey_product].Resource;
					NumericUpDown Product_revenue = Prices_obj[Tkey_product].Product;
					NumericUpDown Product = Prices_obj[Tkey].Product;

					//MessageBox.Show($"Resource:{Resource.Name}\nProduct:{Product.Name}");

					Label Profit_silver = Prices_obj[Tkey_product].Silver_profit;
					Label Profit_percent = Prices_obj[Tkey_product].Percent_profit;
					Label Focus_cost = Prices_obj[Tkey_product].Focus_cost;
					Label Focus_profit = Prices_obj[Tkey_product].Focus_profit;
					Label Fp_Fc = Prices_obj[Tkey_product].Fp_Fc;

					Compute_Profit(Resource, Product_revenue, Product, Profit_silver, Profit_percent, Focus_cost, Focus_profit, Fp_Fc, tier, enchant);

					
				}
                numValueChanged_Resource(Prices_obj[Tkey].Resource, e);

            }

		}
	}
}
