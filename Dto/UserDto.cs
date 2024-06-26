﻿namespace Pasar_Maya_Api.Dto
{
	public class UserDto
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
		public string Picture { get; set; }
		public string NotificationToken { get; set; }
		public int Status { get; set; }

		public int MarketId { get; set; }
	}
}
