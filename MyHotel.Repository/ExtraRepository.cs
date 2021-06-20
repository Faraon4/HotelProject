namespace MyHotel.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;
    using MyHotel.Models;

    /// <summary>
    /// Repository class for extra activity.
    /// </summary>
    public class ExtraRepository : RepositoryClass<Extra>, IExtraRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtraRepository"/> class.
        /// </summary>
        /// <param name="ctx">ctx parameter that will connect to our Db.</param>
        public ExtraRepository(HotelDbContext ctx)
            : base(ctx)
        {
        }

        /// <summary>
        /// Implementing the AddNewExtra method from IExtraRepository , that will add a new extra activity.
        /// </summary>
        /// <param name="newExtra">new extra aactivity as a parameter.</param>
        public void AddNewExtra(Extra newExtra)
        {
            this.ctx.Add(newExtra);
            this.ctx.SaveChanges();
        }

        /// <summary>
        /// Implementing the method ChangePriceExtra() from the IExtraRepository Interface, that will change the price of extra activity.
        /// </summary>
        /// <param name="id">id of extra.</param>
        /// <param name="newPrice">new price for the extra.</param>
        public void ChangePriceExtra(int id, int newPrice)
        {
            var extra = this.GetOne(id);
            try
            {
                if (extra == null)
                {
                    throw new ExtraRepException("Extra Activity is not found");
                }
                else
                {
                    extra.ExtraPrice = newPrice;
                }
            }
            catch (ExtraRepException ex)
            {
                Console.WriteLine(ex.Message);
            }

            this.ctx.SaveChanges();
        }

        /// <summary>
        /// Implementing the DeleteExtra Method from IExtraRepository, that is deleting extra activity.
        /// </summary>
        /// <param name="extraId">id of the extra that want to delete.</param>
        public void DeleteExtraRepository(int extraId)
        {
            var extra = this.GetOne(extraId);

            if (extra == null)
            {
                throw new ExtraRepException("Extra Activity is not found");
            }
            else
            {
                this.ctx.Remove(extra);
            }

            this.ctx.SaveChanges();
        }

        /// <summary>
        /// Implementing the abstract method.
        /// </summary>
        /// <param name="id">id parameter.</param>
        /// <returns>return an Extra activity by the id parameter input.</returns>
        public override Extra GetOne(int id)
        {
            return this.GetAll().SingleOrDefault(x => x.Id == id);
        }
    }
}
