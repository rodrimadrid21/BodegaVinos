﻿using BodegaVinos.Entities;

namespace BodegaVinos.Repositories
{
    public class WineRepository
    {
        private List<Wine> _wines = new List<Wine>();  //lista de vinos
        private int _currentId = 1; //ID en 1

        public List<Wine> GetAllWines()
        {
            return _wines;
        }

        public Wine GetWineByName(string name)
        {
            return _wines.FirstOrDefault(w => w.Name.Equals(name, System.StringComparison.OrdinalIgnoreCase));
        }

        public void AddWine(Wine wine)
        {
            wine.Id = _currentId;
            _currentId++;          
            _wines.Add(wine);
        }

        public void UpdateWineStock(string name, int newStock)
        {
            var wine = _wines.FirstOrDefault(w => w.Name.Equals(name, System.StringComparison.OrdinalIgnoreCase));
            if (wine != null)
            {
                wine.Stock = newStock;
            }
        }
    }
}
