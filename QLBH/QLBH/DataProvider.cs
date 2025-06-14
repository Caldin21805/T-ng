using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;

namespace QLBH
{
    public static class DataProvider
    {
        static string ChuoiKetNoi = @"Server=DESKTOP-CR690E6;Database=QLBanHang;Trusted_Connection=True;";
        public static DataTable TruyVanDuLieu(string query)
        {
            var dt = new DataTable();  //gọi DataTable ở ngoài này mới return đc :D
            //PROCESS LOGIC....
            using (var connection = new SqlConnection(ChuoiKetNoi)) //Dùng using để nó tự động connection.Close() khi xong khỏi phải dùng finally
            {
                {  
                    try
                    {
                        connection.Open();
                        var adapter = new SqlDataAdapter(query, connection); //lấy query ....
                        adapter.Fill(dt); // "đổ" truy vấn vào datatable rồi nó sẽ cook thành dữ liệu có cấu trúc bảng
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi kết nối: " + ex.Message);
                    }
                }
            }
            return dt;
        }
        public static void DinhNghiaDuLieu(string DML) //CHứ mà chẳng hạn dùng void thì chẳng biết nó thành công hay thất bại
        { //Mục địch hàm này dùng bool: Chỉ để báo thành công hay thất bại thôi, chứ không trả về dữ liệu như adapter Nếu thành công (true) → Có nghĩa là SQL chạy ngon, còn bao nhiêu dòng bị ảnh hưởng thì nó không quan tâm.

            //PROCESS LOGIC....
            using (var connection = new SqlConnection(ChuoiKetNoi)) //Dùng using để nó tự động connection.Close() khi xong khỏi phải dùng finally
            {
                {  
                    try
                    {
                        connection.Open();
                        var command = new SqlCommand(DML, connection); //lấy DML....
                        command.ExecuteNonQuery(); //Thực thi lệnh (INSERT, UPDATE, DELETE)
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi kết nối: " + ex.Message);
                    }
                   
                }
            }
        }


        public static void Excute(string DML, CommandType Type, SqlParameter[] parameters) //CHứ mà chẳng hạn dùng void thì chẳng biết nó thành công hay thất bại
        { //Mục địch hàm này dùng bool: Chỉ để báo thành công hay thất bại thôi, chứ không trả về dữ liệu như adapter Nếu thành công (true) → Có nghĩa là SQL chạy ngon, còn bao nhiêu dòng bị ảnh hưởng thì nó không quan tâm.

            //PROCESS LOGIC....
            using (var connection = new SqlConnection(ChuoiKetNoi)) //Dùng using để nó tự động connection.Close() khi xong khỏi phải dùng finally
            {
                {
                    try
                    {
                        connection.Open();
                        var command = new SqlCommand
                        {
                            Connection = connection,
                            CommandType = Type,
                            CommandText = DML

                        };

                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }


                        command.ExecuteNonQuery(); //Thực thi lệnh (INSERT, UPDATE, DELETE)
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi kết nối: " + ex.Message);
                    }

                }
            }
        }





    }
}
