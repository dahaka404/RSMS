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
        private RSMSDBContext BookingContext = new RSMSDBContext();

        public BookingRepository()
        { }

        public BookingRepository(RSMSDBContext pBookingContext)
        {
            this.BookingContext = pBookingContext;
        }

        public ICollection<Booking> GetBookings()
        {
            return BookingContext.Booking.ToList();
        }

        public ICollection<Booking> GetBookingsFromPeriod(DateTime pDateFrom, DateTime pDateTo)
        {
            var lBookings = from booking in BookingContext.Booking
                                 select new
                                 {
                                     booking.Id,
                                     booking.ContactName,
                                     booking.DateTime,
                                     booking.PartyNumber,
                                     booking.SpecialOccasion,
                                     booking.OtherDetails
                                 };

            var list = lBookings.Where(b => b.DateTime >= pDateFrom && b.DateTime <= pDateTo).ToList();

            return list as ICollection<Booking>;
                                                    
        }

        public Booking GetBooking(Guid pBookingID)
        {
            return BookingContext.Booking.Find(pBookingID);
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
            Booking lBooking = BookingContext.Booking.Find(pBookingID);
            if(lBooking != null)
            {
                BookingContext.Booking.Remove(lBooking);
            }
        }

        public Booking GetTableBooking(Guid pBookingID)
        {
            var lTableBooking = from booking in BookingContext.Booking
                                join tablebooking in BookingContext.TableBooking
                                   on booking.Id equals tablebooking.BookingId
                                join table in BookingContext.Table
                                   on tablebooking.TableId equals table.Id
                                select new
                                {
                                    booking.Id,
                                    booking.ContactName,
                                    booking.DateTime,
                                    booking.PartyNumber,
                                    booking.SpecialOccasion,
                                    booking.OtherDetails,
                                    table.Number
                                };

            return lTableBooking.Where(b => b.Id == pBookingID) as Booking;
        }

        public ICollection<Booking> GetTableBookings()
        {
            var lTableBookings = from booking in BookingContext.Booking
                                 join tablebooking in BookingContext.TableBooking
                                    on booking.Id equals tablebooking.BookingId
                                 join table in BookingContext.Table
                                    on tablebooking.TableId equals table.Id
                                 select new
                                 {
                                     booking.Id,
                                     booking.ContactName,
                                     booking.DateTime,
                                     booking.PartyNumber,
                                     booking.SpecialOccasion,
                                     booking.OtherDetails,
                                     table.Number
                                 };

            return lTableBookings.ToList() as ICollection<Booking>;
        }

        public ICollection<Booking> GetTableBookingsFromPeriod(DateTime pDateFrom, DateTime pDateTo)
        {
            var lTableBookings = from booking in BookingContext.Booking
                                    join tablebooking in BookingContext.TableBooking
                                        on booking.Id equals tablebooking.BookingId
                                    join table in BookingContext.Table
                                        on tablebooking.TableId equals table.Id
                                 select new
                                 {
                                     booking.Id,
                                     booking.ContactName,
                                     booking.DateTime,
                                     booking.PartyNumber,
                                     booking.SpecialOccasion,
                                     booking.OtherDetails,
                                     table.Number
                                 };

            return lTableBookings.Where(b => b.DateTime >= pDateFrom && b.DateTime <= pDateTo).ToList() as ICollection<Booking>;
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
            if(lTableBooking != null)
            {
                BookingContext.TableBooking.Remove(lTableBooking);
            }
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
