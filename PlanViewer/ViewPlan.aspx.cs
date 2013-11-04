using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PlanViewer.Models;
namespace PlanViewer
{
    public partial class ViewPlan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            viewPlan();
        }
        
        protected void PlansDataSource_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {
            
        }        
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewPlan();
        }
        Plan[] res;
        Contractor[] contr;
        Customer[] cust;
        int planindex;
        private void viewPlan()
        {
            
            try
            {
                string[] selected = DropDownList1.SelectedValue.Split(' ');                
                planindex = int.Parse(selected[1].Substring(1).Trim());
                ClientScript.RegisterStartupScript(this.GetType(), "Ошибка", "  " + planindex, true);
            }
            catch (IndexOutOfRangeException)
            {
                planindex = 1;
            }
            catch (Exception)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Ошибка", "Ошибка поиска", true);
                planindex = 1;
            }
            //ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert(' index = " + planindex + "');", true);
            try
            {
                var db = new DBClassesDataContext();
                IQueryable<Plan> plans = db.Plans;
                IQueryable<Contractor> contrs = db.Contractors;
                IQueryable<Customer> custs = db.Customers;
                plans = plans.Where(p => p.ID == planindex);
                res = plans.ToArray<Plan>();
                contrs = contrs.Where(p => p.ID == res[0].Contractor);
                contr= contrs.ToArray<Contractor>();
                custs = custs.Where(p => p.ID == res[0].Customer);
                cust = custs.ToArray<Customer>();
                Table1.Rows[1].Cells[0].Text = res[0].ID.ToString();
                try
                {
                    Table1.Rows[1].Cells[1].Text = cust[0].Name.ToString();
                    Table1.Rows[1].Cells[2].Text = contr[0].Name.ToString();
                    
                }
                catch (Exception)
                { }
                Table1.Rows[1].Cells[3].Text = res[0].Object.ToString();
                Table1.Rows[1].Cells[4].Text = res[0].WorkType.ToString();
                Table1.Rows[1].Cells[5].Text = res[0].CostName.ToString();
                Table1.Rows[1].Cells[6].Text = res[0].UnitName.ToString();
                Table1.Rows[1].Cells[7].Text = res[0].Labor.ToString();
                Table1.Rows[1].Cells[8].Text = res[0].Materials.ToString();
                Table1.Rows[1].Cells[9].Text = res[0].Mechnisms.ToString();
                switch (res[0].Status)
                {
                    case 1:
                        Table1.Rows[1].Cells[10].Text = "Подтвержден";
                        Table1.Rows[1].Cells[10].BackColor = System.Drawing.Color.Green;
                        break;
                    case 2:
                        Table1.Rows[1].Cells[10].Text = "Отклонен";
                        Table1.Rows[1].Cells[10].BackColor = System.Drawing.Color.Red;
                        break;
                    case 3:
                        Table1.Rows[1].Cells[10].Text = "Ожидает подтверждения";
                        Table1.Rows[1].Cells[10].BackColor = System.Drawing.Color.Yellow;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
                //ClientScript.RegisterStartupScript(this.GetType(), "Ошибка", "нет записи", true);
                Alert.Show("Ошибка загрузки данных");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var db = new DBClassesDataContext();
            var query =
                from plan in db.Plans
                where plan.ID == planindex                
                select plan;
            query.ToArray()[0].Status = 1;
            try
            {
                db.SubmitChanges();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.StackTrace);
            }
            viewPlan();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var db = new DBClassesDataContext();
            var query =
                from plan in db.Plans
                where plan.ID == planindex
                select plan;
            query.ToArray()[0].Status = 2;
            try
            {
                db.SubmitChanges();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.StackTrace);
            }
            viewPlan();
            string email;
            try
            {
                email = contr[0].Email;
            }
            catch (Exception)
            {
                email = "";
            }
            ClientScript.RegisterStartupScript(this.GetType(), "mailto",
               "<script type = 'text/javascript'>parent.location='mailto:" + email +
               "'</script>");
        }
    }
}