using MySql.Data.MySqlClient;
using System;



namespace MysqlConnectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            //connect mySQL 
            string connStr = "server=localhost;user=root;database=Cosmetic_Website;port=3306;password=Uyentomboy2405@";

            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand command = conn.CreateCommand();
            Console.WriteLine("Final Exam by Nguyen Thi Thu Uyen - SQL");

            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

                //SQL Query to execute
                // add product
                // string sql = "Insert into products Values (232,'Table Cloth 72x144 White','Wine - Red, Marechal Foch','Exercise Treatment of GU Sys using Aerobic Equipment','Therapeutic Exercise Treatment of Genitourinary System using Aerobic Endurance and Conditioning Equipment','0','0','1','19.64','25.61','no-image.jpg','2021-11-28','2022-05-04','9','4','9')";
                // MySqlCommand cmd = new MySqlCommand(sql,conn);
                // cmd.ExecuteNonQuery();

                //sql update
                //update product
                Console.WriteLine("1. Update product: ");
                Console.WriteLine("Enter id: ");
                int id1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter name of product:");
                string name1 = Console.ReadLine();
                Console.WriteLine("Enter sumary-description:");
                string sumarydesc = Console.ReadLine();
                // string sql3 =  "Update products set `name` = name1, `sumary-description` = sumarydesc where id = id1;";
                //MySqlCommand cmd3 = new MySqlCommand(sql3,conn);
                // cmd3.ExecuteNonQuery();
                string sql3 = "Update products set `name` = @name_product , `sumary-description` = @sumarydesc_product where id = @id_product";
                //MySqlCommand cmd3 = new MySqlCommand(sql3,conn);
                MySqlCommand cmd3 = new MySqlCommand(sql3,conn);
                cmd3.CommandText = sql3;
                cmd3.Parameters.AddWithValue("@id_product",Convert.ToInt16(id1));
                cmd3.Parameters.AddWithValue("@name_product",name1);
                cmd3.Parameters.AddWithValue("@sumarydesc_product",sumarydesc);
                cmd3.ExecuteNonQuery();

                do
                {
                    Console.WriteLine("2. Input products information (yes/no):");
                    choice = Console.ReadLine();
                    switch(choice)
                    {
                        case "yes":
                        {
                            Console.WriteLine("Enter id: ");
                            int id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter name:");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter code:");
                            string code = Console.ReadLine();
                            Console.WriteLine("Enter sumary-desc:");
                            string SumDesc = Console.ReadLine();
                            Console.WriteLine("Enter detail-desc:");
                            string DetailDesc = Console.ReadLine();
                            Console.WriteLine("Best-seller(0/1):");
                            int BestSeller = int.Parse(Console.ReadLine());
                            Console.WriteLine("Feature(0/1):");
                            int Feature = int.Parse(Console.ReadLine());
                            Console.WriteLine("New-arrival(0/1):");
                            int NewArrival = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter price-for-sell");
                            double PriceForSell = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter price-comparation");
                            double PriceCompare = double.Parse(Console.ReadLine());
                            Console.WriteLine("Input image");
                            string Images = Console.ReadLine();
                            Console.WriteLine("Date-post(yyyy-mm-dd)");
                        
                            string DatePost = Console.ReadLine();
                            Console.WriteLine("Date-Edit(yyyy-mm-dd)");
                            string DateEdit = Console.ReadLine();
                            Console.WriteLine("BranchID");
                            int BranchID = int.Parse(Console.ReadLine());
                            Console.WriteLine("CreaterID");
                            int CreaterID = int.Parse(Console.ReadLine());
                            Console.WriteLine("EditerID");
                            int EditerID = int.Parse(Console.ReadLine());

                            string sql2 = "Insert into products(`id`,`name`,`code`,`sumary-description`,`detail-description`,`Best-seller`,`Feature`,`new-arrival`,`price_for_sell`,`price_comparation`,`image_representative`,`date_post`,`date_edit`,`Branch_id`,`Creater_id`,`Editer_id`) Values (@id_pro,@name_pro,@code_pro,@sumary_pro,@detail_pro,@Best_pro,@Feature_pro,@new_pro,@price_for_sell_pro,@price_comparation_pro,@image_representative_pro,@date_post_pro,@date_edit_pro,@Branch_id_pro,@Creater_id_user,@Editer_id_user)";
                            MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                                cmd2.CommandText = sql2;
                                cmd2.Parameters.AddWithValue("@id_pro", Convert.ToInt16(id));
                                cmd2.Parameters.AddWithValue("@name_pro", name);
                                cmd2.Parameters.AddWithValue("@code_pro", code);
                                cmd2.Parameters.AddWithValue("@sumary_pro", SumDesc);
                                cmd2.Parameters.AddWithValue("@detail_pro", DetailDesc);
                                cmd2.Parameters.AddWithValue("@Best_pro", Convert.ToInt16(BestSeller));
                                cmd2.Parameters.AddWithValue("@Feature_pro", Convert.ToInt16(Feature));
                                cmd2.Parameters.AddWithValue("@new_pro", Convert.ToInt16(NewArrival));
                                cmd2.Parameters.AddWithValue("@price_for_sell_pro", Convert.ToDouble(PriceForSell));
                                cmd2.Parameters.AddWithValue("@price_comparation_pro", Convert.ToDouble(PriceCompare));
                                cmd2.Parameters.AddWithValue("@image_representative_pro", Images);
                                cmd2.Parameters.AddWithValue("@date_post_pro", DatePost);
                                cmd2.Parameters.AddWithValue("@date_edit_pro", DateEdit);
                                cmd2.Parameters.AddWithValue("@Branch_id_pro", Convert.ToInt16(BranchID));
                                cmd2.Parameters.AddWithValue("@Creater_id_user", Convert.ToInt16(CreaterID));
                                cmd2.Parameters.AddWithValue("@Editer_id_user", Convert.ToInt16(EditerID));
                                //cmd2.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
                                //cmd2.Parameters.Add("?name", MySqlDbType.VarChar).Value = name;
                                // cmd2.Parameters.Add("?code", MySqlDbType.VarChar).Value = code;
                                // cmd2.Parameters.Add("?`sumary-description`", MySqlDbType.VarChar).Value = SumDesc;
                                // cmd2.Parameters.Add("?`detail-description`", MySqlDbType.Text).Value = DetailDesc;
                                // cmd2.Parameters.Add("?Best-seller", MySqlDbType.Int32).Value = BestSeller;
                                // cmd2.Parameters.Add("?Feature", MySqlDbType.Int32).Value = Feature;
                                // cmd2.Parameters.Add("?new-arrival", MySqlDbType.Int32).Value = NewArrival;
                                // cmd2.Parameters.Add("?price_for_sell", MySqlDbType.Double).Value = PriceForSell;
                                // cmd2.Parameters.Add("?`price_comparation`", MySqlDbType.Double).Value = PriceCompare;
                                // cmd2.Parameters.Add("?`image_representative`", MySqlDbType.VarChar).Value = Images;
                                // cmd2.Parameters.Add("?date_post", MySqlDbType.DateTime).Value = DatePost;
                                // cmd2.Parameters.Add("?date_edit", MySqlDbType.DateTime).Value = DateEdit;
                                // cmd2.Parameters.Add("?`Branch_id`", MySqlDbType.Int32).Value = BranchID;
                                // cmd2.Parameters.Add("?`Creater_id`", MySqlDbType.Int32).Value = CreaterID;
                                // cmd2.Parameters.Add("?`Editer_id`", MySqlDbType.Int32).Value = EditerID;
                                cmd2.ExecuteNonQuery();
                            
                            //MySqlCommand cmd2 = new MySqlCommand(sql2,conn);
                            //cmd2.ExecuteNonQuery();
                            
                            //MySqlCommand comm = conn.CreateCommand();
                            //comm.CommandText = "INSERT INTO products(id,name) VALUES(?id, ?name)";
                            //comm.Parameters.Add("?person", "Myname");
                            //comm.Parameters.Add("?address", "Myaddress");
                            //comm.ExecuteNonQuery();
                            

                            

                        }break;
                        case "exit":
                        Environment.Exit(0);
                        break;
                    }
                } while (choice == "yes");
                
                    
                

                //SQL Query to execute
              // search by category
                Console.WriteLine("3. Search category by name: ");
                Console.WriteLine("Enter name of category: ");
                string name2 = Console.ReadLine();
                string sql1 = "select*from category where `name` = @category_name limit 0,24;";
                MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
                cmd1.CommandText = sql1;
                cmd1.Parameters.AddWithValue("@category_name",name2);
                MySqlDataReader rdr = cmd1.ExecuteReader();
                Console.WriteLine("\nResult search by category's name:");

                //read the data
                while (rdr.Read())
                {
                    
                    Console.WriteLine(rdr["id"]+"--"+rdr["name"]+"--"+rdr[2]);
                   
                }
                rdr.Close();

                // search by price
                Console.WriteLine("4. Search products by price: ");
                Console.WriteLine("Maximum price of products that you are looking for: ");
                double price1 = double.Parse(Console.ReadLine());
                string sql4 = "select*from products where `price_for_sell` <= @price_product limit 0,24;";
                MySqlCommand cmd4 = new MySqlCommand(sql4, conn);
                cmd4.CommandText = sql4;
                cmd4.Parameters.AddWithValue("@price_product",Convert.ToDouble(price1));
                MySqlDataReader rdr1 = cmd4.ExecuteReader();
                Console.WriteLine("\nResult search by price:");

                //read the data
                while (rdr1.Read())
                {
                    
                    Console.WriteLine(rdr1["id"]+"--"+rdr1["name"]+"--"+rdr1["Best-seller"]);
                   
                }
                rdr1.Close();

                //search by name

                Console.WriteLine("5. Search products by name: ");
                Console.WriteLine("Name of products that you are looking for: ");
                string name3 = Console.ReadLine();

                string sql5 = "select*from products where `name` = @name_pro_search limit 0,24";
                MySqlCommand cmd5 = new MySqlCommand(sql5, conn);
                cmd5.CommandText = sql5;
                cmd5.Parameters.AddWithValue("@name_pro_search",name3);
                MySqlDataReader rdr2 = cmd5.ExecuteReader();
                Console.WriteLine("\nResult search by product name:");

                //read the data
                while (rdr2.Read())
                {
                    
                    Console.WriteLine(rdr2["id"]+"--"+rdr2["name"]+"--"+rdr2["Sumary-description"]);
                   
                }
                rdr1.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
            }
            conn.Close();
            Console.WriteLine("Thanks for your attention <3 _ Uyen Emily");
            Console.WriteLine("Connection Closed. Press any key to exit...");
            Console.ReadKey();
        }
    }
}