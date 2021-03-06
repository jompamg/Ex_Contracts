﻿using System;
using System.Collections.Generic;
using System.Text;
using Ex_Contracts.Entites.Enums;
using Ex_Contracts.Entites;

namespace Ex_Contracts.Entites
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client )
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void addItem (OrderItem item)
        {
            Items.Add(item);
        }

        public void removeItem (OrderItem item)
        {
            Items.Remove(item);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + DateTime.Now);
            sb.Append("Order status: " + Status);

            return sb.ToString();
        }

    }
}
