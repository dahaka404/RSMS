using Microsoft.EntityFrameworkCore;
using RSMSDAL.DBContext;
using RSMSDATAMODELS.Data_Models;
using RSMSREPO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSMSREPO.Repos
{
    public class BookingRepository : IBookingRepository, IDisposable
    {
        private RSMSDBContext BookingContext;

        public BookingRepository(RSMSDBContext pBookingContext)
        {
            this.BookingContext = pBookingContext;
        }

        public ICollection<TableBooking> GetBookings()
        {
            return BookingContext.TableBooking.ToList();
        }

        public ICollection<TableBooking> GetBookingsFromPeriod(DateTime pDateFrom, DateTime pDateTo)
        {
            var lTableBookings = from booking in BookingContext.Booking
                                 join tablebooking in BookingContext.TableBooking
                                    on booking.Id equals tablebooking.BookingId
                                 join table in BookingContext.Table
                                    on tablebooking.TableId equals table.Id
                                 select new
                                 {
                                     tablebooking.BookingId,
                                     tablebooking.TableId,
                                     booking.DateTime
                                 };

            var list = lTableBookings.Where(tb => tb.DateTime >= pDateFrom && tb.DateTime <= pDateTo).ToList();

            return list.Select(tb => new { tb.BookingId, tb.TableId }).ToList() as ICollection<TableBooking>;
                                                    
        }

        public TableBooking GetBooking(Guid pBookingID)
        {
            return BookingContext.TableBooking.Find(pBookingID);
        }

        public void InsertBooking(Booking pBooking)
        {
            BookingContext.Booking.Add(pBooking);
        }

        public void UpdateBooking(Booking pBooking)
        {
            BookingContext.Entry(pBooking).State = EntityState.Modified;
        }

        public void DeleteBooking(Guid pBookingID)
        {
            TableBooking lTableBooking = BookingContext.TableBooking.Find(pBookingID);
            BookingContext.TableBooking.Remove(lTableBooking);
        }

        public void InsertTableBooking(TableBooking pTableBooking)
        {
            BookingContext.TableBooking.Add(pTableBooking);
        }

        public void UpdateTableBooking(TableBooking pTableBooking)
        {
            BookingContext.Entry(pTableBooking).State = EntityState.Modified;
        }

        public void DeleteTableBooking(Guid pBookingID)
        {
            TableBooking lTableBooking = BookingContext.TableBooking.Find(pBookingID);
            BookingContext.TableBooking.Remove(lTableBooking);
        }

        public void Save()
        {
            BookingContext.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool pDisposing)
        {
            if(!this.disposed)
            {
                if(pDisposing)
                {
                    BookingContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
