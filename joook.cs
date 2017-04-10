string sql = "Select UserId From User where UserName='Gheorghe'";

SqlCommand cmd=new SqlCommand(sql, connection);
SqlDataReader rd = cmd.ExecuteReader(); 
if (rd.HasRows) {
  rd.Read(); // read first row
  var userId = rd.GetInt32(0);
}