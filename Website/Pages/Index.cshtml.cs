/**
 * Author: May Phyo
 * Page represents the menu/home page
 * 
 */
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CowboyCafe.Data;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Enumerable list of menu items based on filter items
        /// </summary>
        public IEnumerable<IOrderItem> menuItems { get; protected set; } = Menu.MenuOrder();

        /// <summary>
        /// Gets term to search by 
        /// </summary>
        [BindProperty]
        public string search { get; set; }

        /// <summary>
        /// Categories of items selected
        /// </summary>
        [BindProperty]
        public string[] menuCategory { get; set; }

        /// <summary>
        /// Minimum price 
        /// </summary>
        [BindProperty]
        public double? minimumPrice { get; set; }

        /// <summary>
        /// Maximum price 
        /// </summary>
        [BindProperty]
        public double? maximumPrice { get; set; }

        /// <summary>
        /// Minimum calories 
        /// </summary>
        [BindProperty]
        public int? minimumCalories { get; set; }

        /// <summary>
        /// Maximum calories 
        /// </summary>
        [BindProperty]
        public int? maximumCalories { get; set; }

        /// <summary>
        /// Counts items 
        /// </summary>
        [BindProperty]
        public int Count { get; set; } = 0;

        /// <summary>
        /// Gets and set jerked soda flavors
        /// </summary>
        [BindProperty]
        public bool RetrieveJerkedSoda { get; set; } = false;

        /// <summary>
        /// Filter menu
        /// </summary>
        /// <param name="MinimumPrice">Minimium Price inputed in box</param>
        /// <param name="MaximumPrice">Maximum Price inputed in box</param>
        /// <param name="MinimumCalories">Minimium Calories inputed in box</param>
        /// <param name="MaximumCalories">Maximum Calories inputed in box</param>
        public void OnGet(double? MinimumPrice, double? MaximumPrice, int? MinimumCalories, int? MaximumCalories)
        {
            this.minimumPrice = MinimumPrice;
            this.maximumPrice = MaximumPrice;
            this.minimumCalories = MinimumCalories;
            this.maximumCalories = MaximumCalories;
            search = Request.Query["search"];
            menuCategory = Request.Query["MenuCategory"];
            menuItems = Menu.Search(menuItems, search);
            menuItems = Menu.FilterByPrice(menuItems, minimumPrice, maximumPrice);
            menuItems = Menu.FilterByCalories(menuItems, minimumCalories, maximumCalories);
            menuItems = Menu.FilterByType(menuItems, menuCategory);
        }
     
    }
}
