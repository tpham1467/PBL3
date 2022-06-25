﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetManagement.DTO;
using NetManagement.Model;
using NetManagement.Repositories;

namespace NetManagement.BLL
{
    public class AdminBLL_Inventory
    {
        private IRepository<Inventory> repository;

        public AdminBLL_Inventory() : this(new GenericRepository<Inventory>())
        {

        }

        public AdminBLL_Inventory(IRepository<Inventory> _repository)
        {
            repository = _repository;
        }
        public IEnumerable<Inventory> GetAll()
        {
            IEnumerable<Inventory> data = repository.GetAll().ToList();
            return data;
        }
        public IEnumerable<object> Filter(int ChooseTab,IEnumerable<Inventory> inventories = null)
        {
            if (inventories == null) inventories = GetAll();
            
            if (ChooseTab == 0)
            {
                return inventories.Select(
                        p =>
                            new
                            {
                                p.ID_Inventory,
                                p.Product.NameProduct,
                                p.Amount,
                                p.Product.Unit.NameUnit,
                                p.ImportDay,
                                p.ExpiryDate
                            }
                    );
            }
            else
            {
                return inventories.Select(
                        p =>
                            new
                            {
                                p.ID_Inventory,
                                p.Product.NameProduct,
                                p.Amount,
                                p.Product.Unit.NameUnit,
                                p.ImportPrices,
                                p.SalePrice
                            }
                    );
            }

        }
        public Inventory GetProductById(int id)
        {
            return repository.GetById(id);

        }
        public void DelProduct(string s)
        {
            repository.Delete(Convert.ToInt32(s));
            repository.Save();
        }
        public void UpdateAdd(string str, Inventory pro)
        {
            bool add = true;
            foreach (Inventory i in GetAll())
            {
                if (i.ID_Inventory == Convert.ToInt32(str))
                {
                    add = false;
                    break;
                }
            }
            if (add)
            {
                Add(pro);
            }
            else
            {
                pro.ID_Inventory = Convert.ToInt32(str);
                UpDate(pro);
            }
            repository.Save();
        }
        public void Add(Inventory pro)
        {
            repository.Insert(pro);
            repository.Save();
            
            Inventory inven = GetAll().Last();
            repository.Save();
        }

        public Inventory CreateIn()
        {
            return repository.Create();
        }

        public void UpdateDelegate(Inventory p1, Inventory p2)
        {
            p1.ExpiryDate = p2.ExpiryDate; p1.ImportPrices = p2.ImportPrices; p1.SalePrice = p2.SalePrice;p1.ImportDay = p2.ImportDay;
            p1.ID_Inventory = p2.ID_Inventory; p1.ID_Product = p2.ID_Product;
        }

        public void UpDate(Inventory exPro)
        {
            repository.Update(exPro, exPro.ID_Inventory, UpdateDelegate);
            repository.Save();
        }

        public IEnumerable<object> Sort(SortEnum sort, string by)
        {
            if (string.Compare(by, "ImportDay") == 0)
                return Filter(0,repository.Sort<DateTime>(sort, a => a.ImportDay));
            else if (string.Compare(by, "ExpiryDate") == 0) 
                return Filter(0,repository.Sort<DateTime>(sort, a => a.ExpiryDate));
            else if (string.Compare(by, "ImportPrices") == 0)
                return Filter(1,repository.Sort<int>(sort, a => a.ImportPrices));
            else
                return Filter(1,repository.Sort<int>(sort, a => a.SalePrice));
        }

        public List<object> Search(int ChooseTab, string search, SearchAcoountEnum searchby)
        {

            if (searchby == SearchAcoountEnum.All)
            {
                return Filter(ChooseTab,repository.GetAll()).ToList();
            }
            else if (searchby == SearchAcoountEnum.Name)
            {
                return Filter(ChooseTab,repository.Search(search, p => p.Product.NameProduct, true, false)).ToList();
            }
            else return Filter(ChooseTab,repository.Search(search, p => p.SalePrice.ToString(), true, false)).ToList();
        }
    }
}
