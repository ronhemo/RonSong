using System;
using System.Data;
using System.Data.OleDb;
using System.Configuration;
using System.Web;
public static class DbQ
{
     const string dbName = "website.mdb";
	/// <summary>
    /// ����� ������ ����� ����� �� ����� ������
    /// </summary>
    /// <param name="dbName">�� ���� �������</param>
    /// <param name="QueryString">������</param>
    /// <returns>���� 1- ����� ������� ����� 1 ����� ����� �����</returns>
    public static int ExecuteNonQuery( String QueryString)
    {
        string dbPath = HttpContext.Current.Server.MapPath("~\\App_Data\\" + dbName);
        string connectionString = @"Data Source='" + dbPath + "';Provider='Microsoft.Jet.OLEDB.4.0';";
        OleDbConnection con = new OleDbConnection(connectionString);

        int retVal;
        con.Open();
        OleDbCommand cmd = new OleDbCommand(QueryString, con);
        try
        {
            retVal = cmd.ExecuteNonQuery();
        }
        catch
        {
            retVal = -1;
        }
        finally
        {
            con.Close();

        }
        return retVal;
    }
    /// <summary>
    /// ���� ������ �������� ���� �����
    /// </summary>
    /// <param name="dbName">�� ���� �������</param>
    /// <param name="QueryString">������</param>
    /// <returns>����� ����� �� ���� ������</returns>
    public static DataSet ExecuteQuery( String QueryString)
    {
        string dbPath = HttpContext.Current.Server.MapPath("~\\App_Data\\" + dbName);
        //������ ������� ����� ���� 2003
        string connectionString = @"Data Source='" + dbPath + "';Provider='Microsoft.Jet.OLEDB.4.0';";
        //����� ������ ������� ����� ������ ��������
        OleDbConnection con = new OleDbConnection(connectionString);
        //����� ������ 
        con.Open();
        //����� ������ ������ ����� ������� ���� ������ �����
        OleDbCommand cmd = new OleDbCommand(QueryString,con);
        //����� ������
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        //����� ����� ������� �������
        DataSet ds = new DataSet();
        //����� �������,����� �������,���� ������ �������
        da.Fill(ds, "tbl");
        //����� ������ �������
        con.Close();

        return ds;
    }

    
}
