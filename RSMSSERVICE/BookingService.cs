using RSMSMODELS.Models;
using RSMSREPO.Repos;
using System;
using System.Collections.Generic;

namespace RSMSSERVICE
{
    public class BookingService
    {
        private readonly BookingRepository lBookingRepository;

        public bool CreateBooking(Booking pBooking, List<Guid> pTables)
        {
            bool IsComplete = false;

            try
            {
                RSMSDATAMODELS.Data_Models.Booking lBooking = new RSMSDATAMODELS.Data_Models.Booking();

                Guid lBookingID = new Guid();

                lBooking.Id = lBookingID;
                lBooking.ContactName = pBooking.ContactName;
                lBooking.DateTime = pBooking.BookingDateTime;
                lBooking.PartyNumber = pBooking.PartyNumber;
                lBooking.SpecialOccasion = pBooking.SpecialOccasion;
                lBooking.OtherDetails = pBooking.OtherDetails;

                lBookingRepository.InsertBooking(lBooking);
                lBookingRepository.Save();

                foreach(Guid lItem in pTables)
                {
                    RSMSDATAMODELS.Data_Models.TableBooking lTableBooking = new RSMSDATAMODELS.Data_Models.TableBooking();
                    lTableBooking.BookingId = lBookingID;
                    lTableBooking.TableId = lItem;

                    lBookingRepository.InsertTableBooking(lTableBooking);
                    lBookingRepository.Save();
                }

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

        public bool UpdateBooking(Booking pBooking, List<Guid> pTables)
        {
            bool IsComplete = false;

            try
            {
                RSMSDATAMODELS.Data_Models.Booking lBooking = new RSMSDATAMODELS.Data_Models.Booking();

                Guid lBookingID = new Guid();

                lBooking.Id = lBookingID;
                lBooking.ContactName = pBooking.ContactName;
                lBooking.DateTime = pBooking.BookingDateTime;
                lBooking.PartyNumber = pBooking.PartyNumber;
                lBooking.SpecialOccasion = pBooking.SpecialOccasion;
                lBooking.OtherDetails = pBooking.OtherDetails;

                lBookingRepository.UpdateBooking(lBooking);
                lBookingRepository.Save();

                foreach (Guid lItem in pTables)
                {
                    RSMSDATAMODELS.Data_Models.TableBooking lTableBooking = new RSMSDATAMODELS.Data_Models.TableBooking();
                    lTableBooking.BookingId = lBookingID;
                    lTableBooking.TableId = lItem;

                    lBookingRepository.UpdateTableBooking(lTableBooking);
                    lBookingRepository.Save();
                }

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

        public TableBooking GetBooking(Guid pBookngID)
        {
            RSMSDATAMODELS.Data_Models.TableBooking tableBooking = new RSMSDATAMODELS.Data_Models.TableBooking();
            TableBooking lTableBooking = new TableBooking();

            try
            {
                tableBooking = lBookingRepository.GetBooking(pBookngID);

                lTableBooking.BookingID = tableBooking.BookingId;
                lTableBooking.TableID = tableBooking.TableId;
            }
            catch(Exception ex)
            {
                throw new Exception(String.Concat("Unable to retrieve booking! Error: ", ex.ToString()), new Exception(ex.ToString()));
            }

            return lTableBooking;
        }

        public List<TableBooking> GetBookingsFromPeriod(DateTime pDateFrom, DateTime pDateTo)
        {
            List<TableBooking> lTableBookings = new List<TableBooking>();
            ICollection<RSMSDATAMODELS.Data_Models.TableBooking> tableBookings;

            try
            {
                tableBookings = lBookingRepository.GetBookingsFromPeriod(pDateFrom, pDateTo);

                foreach(var lItem in tableBookings)
                {
                    lTableBookings.Add(new TableBooking(lItem.BookingId, lItem.TableId));
                }
            }
            catch(Exception ex)
            {
                throw new Exception(String.Concat("Unable to retrieve bookings within this range! Error: ", ex.ToString()), new Exception(ex.ToString()));
            }
            return lTableBookings;
        }

        public List<TableBooking> GetBookings()
        {
            List<TableBooking> lTableBookings = new List<TableBooking>();
            ICollection<RSMSDATAMODELS.Data_Models.TableBooking> tableBookings;

            try
            {
                tableBookings = lBookingRepository.GetBookings();

                foreach(var lItem in tableBookings)
                {
                    lTableBookings.Add(new TableBooking(lItem.BookingId, lItem.TableId));
                }
            }
            catch(Exception ex)
            {
                throw new Exception(String.Concat("Unable to retrieve bookings! Error: ", ex.ToString()), new Exception(ex.ToString()));
            }

            return lTableBookings;
        }
    }
}
