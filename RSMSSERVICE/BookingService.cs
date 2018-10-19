using RSMSMODELS.Models;
using RSMSREPO.Repos;
using System;
using System.Collections.Generic;

namespace RSMSSERVICE
{
    public class BookingService
    {
        private readonly BookingRepository lBookingRepository = new BookingRepository();

        public bool CreateBooking(Booking pBooking)
        {
            bool IsComplete = false;

            try
            {
                RSMSDATAMODELS.Data_Models.Booking lBooking = new RSMSDATAMODELS.Data_Models.Booking();

                Guid lBookingID = Guid.NewGuid();

                lBooking.Id = lBookingID;
                lBooking.ContactName = String.IsNullOrEmpty(pBooking.ContactName) ? throw new ArgumentNullException("Contact Name must be provided!", new Exception("Contact Name cannot be Null or Empty!")) : pBooking.ContactName;
                lBooking.DateTime = pBooking.BookingDateTime;
                lBooking.PartyNumber = pBooking.PartyNumber > 80 ? 
                                       throw new ArgumentOutOfRangeException("Members in a party cannot be more than 80, this booking will be a special request", new Exception("Party number Out of Range")) : 
                                       pBooking.PartyNumber <= 0 ? throw new ArgumentOutOfRangeException("Members in a party need to be more than 0", new Exception("Party number Out of Range")): pBooking.PartyNumber;
                lBooking.SpecialOccasion = pBooking.SpecialOccasion;
                lBooking.OtherDetails = pBooking.OtherDetails;

                lBookingRepository.InsertBooking(lBooking);
                lBookingRepository.Save();
            }
            catch(Exception ex)
            {
                throw new Exception(String.Concat("Booking Not Created! Error: ", ex.ToString()), new Exception(ex.ToString()));
            }
            finally
            {
                IsComplete = true;
            }

            return IsComplete;
        }

        public bool UpdateBooking(Booking pBooking)
        {
            bool IsComplete = false;

            try
            {
                RSMSDATAMODELS.Data_Models.Booking lBooking = new RSMSDATAMODELS.Data_Models.Booking();

                Guid lBookingID = new Guid();

                lBooking.Id = lBookingID;
                lBooking.ContactName = String.IsNullOrEmpty(pBooking.ContactName) ? throw new ArgumentNullException("Contact Name must be provided!", new Exception("Contact Name cannot be Null or Empty!")) : pBooking.ContactName;
                lBooking.DateTime = pBooking.BookingDateTime;
                lBooking.PartyNumber = pBooking.PartyNumber > 80 ?
                                       throw new ArgumentOutOfRangeException("Members in a party cannot be more than 80, this booking will be a special request", new Exception("Party number Out of Range")) :
                                       pBooking.PartyNumber <= 0 ? throw new ArgumentOutOfRangeException("Members in a party need to be more than 0", new Exception("Party number Out of Range")) : pBooking.PartyNumber;
                lBooking.SpecialOccasion = pBooking.SpecialOccasion;
                lBooking.OtherDetails = pBooking.OtherDetails;

                lBookingRepository.UpdateBooking(lBooking);
                lBookingRepository.Save();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Concat("Booking Not Created! Error: ", ex.ToString()), new Exception(ex.ToString()));
            }
            finally
            {
                IsComplete = true;
            }

            return IsComplete;
        }

        public bool CancelBooking(Guid pBookingID)
        {
            bool IsComplete = false;

            try
            {
                lBookingRepository.DeleteBooking(pBookingID);
                lBookingRepository.DeleteTableBooking(pBookingID);
                lBookingRepository.Save();
            }
            catch(Exception ex)
            {
                throw new Exception(String.Concat("Booking not removed! Error: ", ex.ToString()), new Exception(ex.ToString()));
            }
            finally
            {
                IsComplete = true;
            }

            return IsComplete;
        }

        public Booking GetBooking(Guid pBookingID)
        {
            RSMSDATAMODELS.Data_Models.Booking booking = new RSMSDATAMODELS.Data_Models.Booking();
            Booking lBooking = new Booking();

            try
            {
                booking = lBookingRepository.GetBooking(pBookingID);

                lBooking.BookingID = booking.Id;
                lBooking.ContactName = booking.ContactName;
                lBooking.BookingDateTime = booking.DateTime;
                lBooking.PartyNumber = booking.PartyNumber;
                lBooking.SpecialOccasion = booking.SpecialOccasion;
                lBooking.OtherDetails = booking.OtherDetails;
            }
            catch(Exception ex)
            {
                throw new Exception(String.Concat("Unable to retrieve booking! Error: ", ex.ToString()), new Exception(ex.ToString()));
            }

            return lBooking;
        }

        public List<Booking> GetBookingsFromPeriod(DateTime pDateFrom, DateTime pDateTo)
        {
            List<Booking> lBookings = new List<Booking>();
            ICollection<RSMSDATAMODELS.Data_Models.Booking> bookings;

            try
            {
                bookings = lBookingRepository.GetBookingsFromPeriod(pDateFrom, pDateTo);

                foreach(var lItem in bookings)
                {
                    lBookings.Add(new Booking(lItem.Id, lItem.ContactName, lItem.DateTime, lItem.PartyNumber, lItem.SpecialOccasion, lItem.OtherDetails));
                }
            }
            catch(Exception ex)
            {
                throw new Exception(String.Concat("Unable to retrieve bookings within this range! Error: ", ex.ToString()), new Exception(ex.ToString()));
            }
            return lBookings;
        }

        public List<Booking> GetBookings()
        {
            List<Booking> lBookings = new List<Booking>();
            ICollection<RSMSDATAMODELS.Data_Models.Booking> lbookings;

            try
            {
                lbookings = lBookingRepository.GetBookings();

                foreach(var lItem in lbookings)
                {
                    lBookings.Add(new Booking(lItem.Id, lItem.ContactName, lItem.DateTime, lItem.PartyNumber, lItem.SpecialOccasion, lItem.OtherDetails));
                }
            }
            catch(Exception ex)
            {
                throw new Exception(String.Concat("Unable to retrieve bookings! Error: ", ex.ToString()), new Exception(ex.ToString()));
            }

            return lBookings;
        }

        public Booking GetTableBooking(Guid pBookingID)
        {
            RSMSDATAMODELS.Data_Models.Booking booking = new RSMSDATAMODELS.Data_Models.Booking();
            Booking lBooking = new Booking();

            try
            {
                booking = lBookingRepository.GetBooking(pBookingID);

                lBooking.BookingID = booking.Id;
                lBooking.ContactName = booking.ContactName;
                lBooking.BookingDateTime = booking.DateTime;
                lBooking.PartyNumber = booking.PartyNumber;
                lBooking.SpecialOccasion = booking.SpecialOccasion;
                lBooking.OtherDetails = booking.OtherDetails;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Concat("Unable to retrieve table booking! Error: ", ex.ToString()), new Exception(ex.ToString()));
            }

            return lBooking;
        }

        public List<Booking> GetTableBookingsFromPeriod(DateTime pDateFrom, DateTime pDateTo)
        {
            List<Booking> lTableBookings = new List<Booking>();
            ICollection<RSMSDATAMODELS.Data_Models.Booking> tablebookings;

            try
            {
                tablebookings = lBookingRepository.GetTableBookingsFromPeriod(pDateFrom, pDateTo);

                foreach (var lItem in tablebookings)
                {
                    lTableBookings.Add(new Booking(lItem.Id, lItem.ContactName, lItem.DateTime, lItem.PartyNumber, lItem.SpecialOccasion, lItem.OtherDetails));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(String.Concat("Unable to retrieve table bookings within this range! Error: ", ex.ToString()), new Exception(ex.ToString()));
            }
            return lTableBookings;
        }

        public List<Booking> GetTableBookings()
        {
            List<Booking> lTableBookings = new List<Booking>();
            ICollection<RSMSDATAMODELS.Data_Models.Booking> tablebookings;

            try
            {
                tablebookings = lBookingRepository.GetBookings();

                foreach (var lItem in tablebookings)
                {
                    lTableBookings.Add(new Booking(lItem.Id, lItem.ContactName, lItem.DateTime, lItem.PartyNumber, lItem.SpecialOccasion, lItem.OtherDetails));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(String.Concat("Unable to retrieve table bookings! Error: ", ex.ToString()), new Exception(ex.ToString()));
            }

            return lTableBookings;
        }

        public bool CreateTableBooking(Guid pBookingId, List<Guid> pTables)
        {
            bool IsComplete = false;

            try
            {
                foreach(var lItem in pTables)
                {
                    RSMSDATAMODELS.Data_Models.TableBooking lTableBooking = new RSMSDATAMODELS.Data_Models.TableBooking
                    {
                        BookingId = pBookingId,
                        TableId = lItem
                    };

                    lBookingRepository.InsertTableBooking(lTableBooking);
                    lBookingRepository.Save();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(String.Concat("Table Booking Not Created! Error: ", ex.ToString()), new Exception(ex.ToString()));
            }
            finally
            {
                IsComplete = true;
            }

            return IsComplete;
        }

        public bool UpdateTableBooking(Guid pBookingId, List<Guid> pOldTables, List<Guid> pNewTables)
        {
            bool IsComplete = false;

            try
            {
                lBookingRepository.DeleteTableBooking(pBookingId);

                foreach(var lItem in pNewTables)
                {
                    RSMSDATAMODELS.Data_Models.TableBooking lTableBooking = new RSMSDATAMODELS.Data_Models.TableBooking
                    {
                        BookingId = pBookingId,
                        TableId = lItem
                    };

                    lBookingRepository.InsertTableBooking(lTableBooking);
                    lBookingRepository.Save();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(String.Concat("Table Booking Not Updated! Error: ", ex.ToString()), new Exception(ex.ToString()));
            }
            finally
            {
                IsComplete = true;
            }

            return IsComplete;
        }
    }
}
