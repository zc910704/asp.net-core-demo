using IRepository;
using System;

namespace Repository
{
    public class AdvertisementRepository: IAdvertisementRepository
    {
        public int Sum(int i, int j)
        {
            return i + j;
        }
    }
}
