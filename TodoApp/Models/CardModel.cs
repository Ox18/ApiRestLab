using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TodoApp.Entity;
using MySql.Data.MySqlClient;


namespace TodoApp.Models
{
    public class CardModel
    {
        public static ResponseCard ReadAll()
        {
            string query = "select * from card";

            MySqlConnection conexion = Conexion.BuildConnection().connection();

            ResponseCard responseCard = new ResponseCard();


            MySqlCommand commandDatabase = new MySqlCommand(query, conexion);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                // Ejecuta la consultas
                reader = commandDatabase.ExecuteReader();
                
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // En nuestra base de datos, el array contiene:  ID 0, FIRST_NAME 1,LAST_NAME 2, ADDRESS 3
                        // Hacer algo con cada fila obtenida
                        Card card = new Card();
                        card.Id = Convert.ToInt32(reader.GetString(0));
                        card.Name = Convert.ToString(reader.GetString(1));
                        card.Description = Convert.ToString(reader.GetString(2));
                        card.category = Convert.ToInt32(reader.GetString(3));
                        card.created_at = Convert.ToString(reader.GetString(4));
                        card.updated_at = Convert.ToString(reader.GetString(5));
                        responseCard.Data.Add(card);
                    }
                    responseCard.message = "Successful";
                }
                else
                {
                    Console.WriteLine("No se encontraron datos.");
                    responseCard.message = "Datos vacios";
                }
                
            }
            catch(Exception ex)
            {
                responseCard.error = true;
                responseCard.message = ex.Message;
            }
            finally
            {
                conexion.Close();
            }

            return responseCard;
        }

        public static ResponseCard Create(Card card)
        {
            string query = "INSERT INTO card (name, description, category) values('" + card.Name+ "','" + card.Description + "' , '" + card.category + "')";

            MySqlConnection conexion = Conexion.BuildConnection().connection();

            MySqlCommand command = conexion.CreateCommand();
            command.CommandText = query;

            ResponseCard responseCard = new ResponseCard();

            try
            {
                command.ExecuteNonQuery();

                responseCard.message = "Successful";
            }
            catch (Exception ex)
            {
                responseCard.error = true;
                responseCard.message = ex.Message;
            }
            finally
            {
                conexion.Close();
            }

            return responseCard;
        }

        
        public static ResponseCard Update(Card card)
        {
            string query = "UPDATE card SET name = '" + card.Name + "', description = '" + card.Description + "', category = '" + card.category + "' WHERE id = '" + card.Id + "';";

            MySqlConnection conexion = Conexion.BuildConnection().connection();

            MySqlCommand MyCommand2 = new MySqlCommand(query, conexion);
            MySqlDataReader MyReader2;

            ResponseCard responseCard = new ResponseCard();

            try
            {
                MyReader2 = MyCommand2.ExecuteReader();

                while (MyReader2.Read())
                {
                }
                responseCard.message = "Successful";
            }
            catch (Exception ex)
            {
                responseCard.error = true;
                responseCard.message = ex.Message;
            }
            finally
            {
                conexion.Close();
            }

            return responseCard;
        }

        public static ResponseCard delete(Card card)
        {
            string query = "DELETE FROM card WHERE id = '" + card.Id + "'";

            MySqlConnection conexion = Conexion.BuildConnection().connection();

            MySqlCommand command = conexion.CreateCommand();
            command.CommandText = query;

            ResponseCard responseCard = new ResponseCard();

            try
            {
                command.ExecuteNonQuery();
                responseCard.message = "Successful";
            }
            catch (Exception ex)
            {
                responseCard.error = true;
                responseCard.message = ex.Message;
            }
            finally
            {
                conexion.Close();
            }

            return responseCard;
        }

    }

    
}