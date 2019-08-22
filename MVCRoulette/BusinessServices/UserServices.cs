using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCRoulette.Models;
using System.Data.SqlClient;

namespace MVCRoulette.BusinessEnitites
{
    public class UserServices
    {
        public void UserGuess(Users user)
        {
            string connectrionString = Properties.Settings.Default.ConnectionString;

            using (SqlConnection con = new SqlConnection(connectrionString))
            {
                SqlCommand cmd = new SqlCommand("update Users set Guess = @Guess where UserID = @UserID", con);

                SqlParameter paramUserID = new SqlParameter();
                paramUserID.ParameterName = "@UserID";
                paramUserID.Value = user.UserID;
                cmd.Parameters.Add(paramUserID);

                SqlParameter paramUserGuess = new SqlParameter();
                paramUserID.ParameterName = "@Guess";
                paramUserID.Value = user.Guess;
                cmd.Parameters.Add(paramUserGuess);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}