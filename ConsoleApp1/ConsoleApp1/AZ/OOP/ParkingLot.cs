using System;
using System.Collections.Generic;

namespace AlgoPractice.AZ
{
    public class ParkingManager
    {

    }

    public class ParkingLot
    {
        public List<ParkingFloor> Floors { get; set; }
    }

    public class ParkingFloor
    {
        public Dictionary<VehicleType, List<ParkingSpot>> Spots { get; set; }
    }

    public class ParkingSpot
    {
        private bool _isAvailable;
        public int SpotNumber { get; set; }
        public VehicleType Type { get; set; }
        public bool IsAvailable()
        {
            return _isAvailable;
        }
    }

    public class Ticket
    {
        public int TicketId { get; set; }
        public DateTime InTime { get; set; }
        public VehicleType Type { get; set; }
    }

    public enum VehicleType
    {
        Bike,
        Car,
        Truck,
        Bus,
        Handicapped
    }

    public abstract class Vehicle
    {
        private VehicleType _type;
        public Vehicle(VehicleType type)
        {
            _type = type;
        }

        public VehicleType GetVehicleType()
        {
            return _type;
        }
    }

    public class Car : Vehicle
    {
        public Car() : base(VehicleType.Car)
        {

        }
    }

    public class Bike : Vehicle
    {
        public Bike() : base(VehicleType.Bike)
        {

        }
    }

    public class Truck : Vehicle
    {
        public Truck() : base(VehicleType.Truck)
        {

        }
    }

    public class Bus : Vehicle
    {
        public Bus() : base(VehicleType.Bus)
        {

        }
    }
}
