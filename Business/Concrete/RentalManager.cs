using System;
using System.Collections.Generic;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        private IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            if (rental.ReturnDate.HasValue)
            {
                return new ErrorResult(Messages.Rental.NotReturned);
            }
            else
            {
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.Rental.Added);
            }
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.Rental.Listed);
        }

        public IDataResult<List<Rental>> GetAllById(int id)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r => r.RentalID == id));
        }

        public IDataResult<List<Rental>> GetAllByRentDate(DateTime date)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r => r.RentDate == date));
        }

        public IDataResult<List<Rental>> GetAllByReturnDate(DateTime date)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r => r.ReturnDate == date));

        }

        public IDataResult<List<Rental>> GetAllByCarId(int id)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r => r.CarID == id));

        }

        public IDataResult<List<Rental>> GetAllByCustomerId(int id)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r => r.CustomerID == id));

        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.Rental.Updated);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.Rental.Deleted);
        }
    }
}