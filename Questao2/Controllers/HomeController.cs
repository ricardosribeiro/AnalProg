using AutoMapper;
using Domain.Entities;
using Infra.Repositories;
using Questao2.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Questao2.Controllers
{
    public class HomeController : Controller
    {
        private readonly SalesOrderRepository _salesOrderRepository;
        private IEnumerable<SalesOrderViewModel> _salesOrderViewModels;
        private SalesOrder _salesOrder;
        private SalesOrderViewModel _salesOrderViewModel;
        public HomeController()
        {
            _salesOrderRepository = new SalesOrderRepository();
        }
        public ActionResult Index()
        {

            _salesOrderViewModels = Mapper.Map<IEnumerable<SalesOrder>, IEnumerable<SalesOrderViewModel>>(_salesOrderRepository.GetAllWithUser());
            return View(_salesOrderViewModels);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SalesOrderViewModel salesOrderViewModel)
        {
            if (ModelState.IsValid)
            {
                _salesOrder = Mapper.Map<SalesOrderViewModel, SalesOrder>(salesOrderViewModel);
                _salesOrderRepository.Add(_salesOrder);
                return RedirectToAction("Index");
            }
            else
            {
                return View(salesOrderViewModel);
            }

        }

        public ActionResult Details(int id)
        {
            _salesOrder = _salesOrderRepository.GetById(id);
            _salesOrderViewModel = Mapper.Map<SalesOrder, SalesOrderViewModel>(_salesOrder);

            return View(_salesOrderViewModel);
        }

        public ActionResult Delete(int id)
        {
            SalesOrderViewModel salesOrderViewModel = Mapper.Map<SalesOrder, SalesOrderViewModel>(_salesOrderRepository.GetById(id));
            return View(salesOrderViewModel);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmation(int id)
        {
            _salesOrder = _salesOrderRepository.GetById(id);
            _salesOrderRepository.Remove(_salesOrder);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            _salesOrder = _salesOrderRepository.GetById(id);
            _salesOrderViewModel = Mapper.Map<SalesOrder, SalesOrderViewModel>(_salesOrder);
            return View(_salesOrderViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SalesOrderViewModel salesOrderViewModel)
        {
            _salesOrder = Mapper.Map<SalesOrderViewModel, SalesOrder>(salesOrderViewModel);
            _salesOrderRepository.Update(_salesOrder);
            return RedirectToAction("Index");
        }

    }
}