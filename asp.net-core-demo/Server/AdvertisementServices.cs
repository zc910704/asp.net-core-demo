using IRepository;
using IServer;
using Repository;
using System;

namespace Server
{
    public class AdvertisementServices : IAdvertisementServices
    {
        IAdvertisementRepository dal = new AdvertisementRepository();
        
        public int Sum(int i, int j)
        {
            return dal.Sum(i, j);

        }
    }
}
