using BookingApp.Business.Operations.Features.Dtos;
using BookingApp.Business.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.Business.Operations.Features
{
    public  interface IFeatureService
    {
        Task<ServiceMessage> AddFeature (AddFeatureDto feature);
    }
}
