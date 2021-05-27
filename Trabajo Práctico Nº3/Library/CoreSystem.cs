﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class CoreSystem
    {
        static List<Operator> operators;
        static List<InternalOrder> internalOrders;
        static List<Device> devicesStock;
        static List<Components> componentsStock;

        public static List<Operator> Operators { get => operators; }
        public static List<InternalOrder> InternalOrders { get => internalOrders; set => internalOrders = value; }
        public static List<Device> DevicesStock { get => devicesStock; set => devicesStock = value; }
        public static List<Components> ComponentsStock { get => componentsStock; set => componentsStock = value; }

        static CoreSystem()
        {
            operators = new List<Operator>();
            internalOrders = new List<InternalOrder>();
            devicesStock = new List<Device>();
            componentsStock = new List<Components>();
            LoadOperators();
            LoadInternalOrder();
            LoadComponentsStock();
        }

        private static void LoadOperators()
        {
            operators.Add(new Operator("Ezequiel", "Unía", 6666, 9999));
            operators.Add(new Operator("Federico", "Dávila", 8080, 7845));
            operators.Add(new Operator("Esteban", "Prieto", 9595, 1331));
            operators.Add(new Operator("Lautaro", "Galarza", 4747, 3030));
        }
        private static void LoadInternalOrder()
        {
            internalOrders.Add(new InternalOrder(4506, ECode.CNT_A60_ID, EType.FingerPrint, 2));
            internalOrders.Add(new InternalOrder(4507, ECode.CNT_A9_CR, EType.Card, 1));
            internalOrders.Add(new InternalOrder(4508, ECode.CNT_BioPanel_ACC, EType.FingerPrint, 3));
            internalOrders.Add(new InternalOrder(4509, ECode.CNT_FD10_FC, EType.Face, 2));
            internalOrders.Add(new InternalOrder(4510, ECode.CNT_E7_CR, EType.Card, 1));
        }

        private static void LoadComponentsStock()
        {
            componentsStock.Add(new Components("Mother", 10));
            componentsStock.Add(new Components("Core", 10));
            componentsStock.Add(new Components("Display", 10));
            componentsStock.Add(new Components("Keyboard", 10));
            componentsStock.Add(new Components("Sound", 10));
            componentsStock.Add(new Components("Case", 10));
            componentsStock.Add(new Components("Led", 10));
        }


    }
}
