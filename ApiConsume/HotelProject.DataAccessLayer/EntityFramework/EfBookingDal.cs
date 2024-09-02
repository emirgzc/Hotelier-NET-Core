﻿using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{
	public class EfBookingDal : GenericRepositories<Booking>, IBookingDal
	{
		public EfBookingDal(Context context) : base(context)
		{

		}

		public void BookingStatusChangeApproved(Booking booking)
		{
			var context = new Context();
			var values = context.Bookings.Where(x=>x.BookingID == booking.BookingID).FirstOrDefault();
			values.Status = "Onaylandı";
			context.SaveChanges();
		}

		public void BookingStatusChangeApproved2(int id)
		{
			var context = new Context();
			var values = context.Bookings.Find(id);
			values.Status = "Onaylandı";
			context.SaveChanges();
		}

        public void BookingStatusChangeApproved3(int id) 
        {
            var context = new Context();
            var values = context.Bookings.Find(id);
            values.Status = "Onaylandı";
            context.SaveChanges();
        }

		public void BookingStatusChangeCancel(int id)
		{
			var context = new Context();
			var values = context.Bookings.Find(id);
			values.Status = "İptal Edildi";
			context.SaveChanges();
		}

		public void BookingStatusChangeWait(int id)
		{
			var context = new Context();
			var values = context.Bookings.Find(id);
			values.Status = "Beklemede";
			context.SaveChanges();
		}

		public int GetBookingCount()
		{
			var context = new Context();
			var value = context.Bookings.Count();
			return value;
		}

		public List<Booking> LastSixBooking()
		{
			var context = new Context();
			return context.Bookings.OrderByDescending(x => x.BookingID).Take(6).ToList();
		}
	}
}