using BSBookingQuery.Interface.Manager;
using BSBookingQuery.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace BSBookingQuery.Controllers
{
    
    public class BookingController : Controller
    {
        private readonly Imanager _bookingManager;

        public BookingController(Imanager bookingManager) { 
            
            _bookingManager = bookingManager;
        }
        public ActionResult Index()
        {
            try {
                var allHotel = _bookingManager.GetAll().ToList();

                return View(allHotel);
            }
            catch(Exception ex) {
                throw new Exception(ex.Message);
            }
        }
     
        public IActionResult Create()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // GET: BookingController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BookingModel obj)
        {
            try {
                
                bool save = _bookingManager.Add(obj);
                if (save) {

                    return RedirectToAction("Index");
                }

                return View();
                
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);   
            }
        }

        [HttpGet("hotelId")]
        [ValidateAntiForgeryToken]
        public ActionResult GetById(int hotelId)
        {
            try
            {
                BookingModel _bookingModel = _bookingManager.GetById(hotelId);

                if (_bookingModel != null)
                {

                    return View(_bookingModel);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public ActionResult GetByName(string name)
        {
            try
            {
                ICollection<BookingModel> _bookingModel = _bookingManager.GetByName(name);

                if (_bookingModel != null)
                {

                    return RedirectToAction(nameof(Index), _bookingModel);
                }
                return RedirectToAction(nameof(Index), _bookingModel);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ActionResult GetByLocation(string location)
        {
            try
            {
                ICollection<BookingModel> _bookingModel = _bookingManager.GetByLocation(location);

                if (_bookingModel != null)
                {

                    return RedirectToAction(nameof(Index), _bookingModel);
                }
                return RedirectToAction(nameof(Index), _bookingModel);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

   
        public ActionResult GetByRating(int rating)
        {
            try
            {
                ICollection<BookingModel> _bookingModel = _bookingManager.GetByRating(rating);

                if (_bookingModel != null)
                {

                    return RedirectToAction(nameof(Index), _bookingModel);
                }
                return RedirectToAction(nameof(Index), _bookingModel);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public ActionResult Details(int Id) 
        {
            try
            {
                BookingModel _bookingModel = _bookingManager.GetById(Id);

                if (_bookingModel != null)
                {

                    return View(_bookingModel);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Details(BookingModel bookingModel)
        {
            try
            {
                bool save = _bookingManager.Update(bookingModel);

                if (save)
                {
                    return RedirectToAction(nameof(Index));
                }
                return View(bookingModel);
            }
            catch
            {
                return View(bookingModel);
            }
        }
        public ActionResult Edit(int editId) 
        {
            try {
                BookingModel _bookingModel = _bookingManager.GetById(editId);

                if (_bookingModel != null)
                {

                    return View(_bookingModel);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(BookingModel bookingModel)
        {
            try
            {
                bool save = _bookingManager.Update(bookingModel);

                if (save) {
                    return RedirectToAction(nameof(Index));
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: BookingController/Delete/5
        public ActionResult Delete(int id)
        {
            try {

                BookingModel _bookingModel = _bookingManager.GetById(id);

                if(_bookingModel != null)
                {
                    bool save = _bookingManager.Delete(_bookingModel);
                }

                return RedirectToAction("Index");
            }catch   (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
