using CiuchApp.Domain;
using System.Collections.Generic;

namespace CiuchApp.Dashboard.Services
{
    public interface IBusinessTripService
    {
        IList<BusinessTrip> GetBusinessTrips();
        bool AddBusinessTrip(BusinessTrip businessTrip);
        bool UpdateBusinessTrip(BusinessTrip businessTrip);
        bool DeleteBusinessTrip(BusinessTrip businessTrip);
        IEnumerable<Piece> GetBusinessTripsPieces(int id);
    }
}