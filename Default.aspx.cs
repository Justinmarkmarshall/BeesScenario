using Bees.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Bees
{
    public partial class _Default : Page
    {
        public List<Bee> _lst_WorkerBees = new List<Bee>();

        public List<Bee> lstBees
        {
            get
            {
                if (!(ViewState["lst_Bees"] is List<Bee>))
                {
                    ViewState["lst_Bees"] = new List<Bee>();
                }

                return (List<Bee>)ViewState["lst_Bees"];
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Load_Bees();
            }
           
        }


        #region Bees

        public void Load_Bees()
        {
            Refresh_Bees_List();
        }

        private void Refresh_Bees_List()
        {

            for (int i = 1; i <= 30; i++)
            {
                if (i > 0 && i <= 10)
                {
                    var objWorkerBee = new WorkerBee();
                    objWorkerBee.Id = i;

                    lstBees.Add(objWorkerBee);
                }
                
                if (i >10 && i <= 20)
                {
                    var objDroneBee = new Drone();
                    objDroneBee.Id = i;

                    lstBees.Add(objDroneBee);
                }

                if (i > 20 && i <= 30)
                {
                    var objQueenBee = new Queen();
                    objQueenBee.Id = i;

                    lstBees.Add(objQueenBee);
                }
            }

            rpt_Bees.DataSource = lstBees;
            rpt_Bees.DataBind();
        }

        #endregion Bees
        protected void btn_InflictDamageClick(object sender, EventArgs e)
        {
            
        }

        protected void rpt_BeesItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Damage")
            {
                var objBeeToUpdate = lstBees.FirstOrDefault(r => r.Id == (e.Item.ItemIndex + 1));

                Random random = new Random();
                int iDamage = random.Next(0, 80);

                objBeeToUpdate.Inflict_Damage(iDamage);

                rpt_Bees.DataSource = lstBees;
                rpt_Bees.DataBind();
            }
        }
    }
}