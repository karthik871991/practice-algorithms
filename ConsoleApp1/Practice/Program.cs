using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{

    public class Solution
    {
        //private static SortedDictionary<string, BuyPriceBook> _buyPriceBook;
        //private static SortedDictionary<string, SellPriceBook> _sellPriceBook;
        //private static Dictionary<string, PriceBook> _priceBook;

        public Solution()
        {
            //_buyPriceBook = new SortedDictionary<string, BuyPriceBook>();
            //_sellPriceBook = new SortedDictionary<string, SellPriceBook>();
            //_priceBook = new Dictionary<string, PriceBook>();
        }

        public static void Main(string[] args)
        {
            while (true)
            {
                var str = Console.ReadLine();
                RunOrderMatchingEngine(str);
            }
        }

        public static void RunOrderMatchingEngine(string str)
        {
            var strArray = str.Split(' ');

            switch (strArray[0])
            {
                case "BUY":
                    {
                        var orderId = strArray[4];
                        var book = PriceBook.CreatePriceBook(strArray[1], int.Parse(strArray[2]), int.Parse(strArray[3]), strArray[4]);
                        _priceBook.Add(orderId, book);



                        HandleTrade();

                        break;
                    }
                case "SELL":
                    {
                        var orderId = strArray[4];
                        var book = PriceBook.CreatePriceBook(strArray[1], int.Parse(strArray[2]), int.Parse(strArray[3]), strArray[4]);
                        _priceBook.Add(orderId, book);

                        HandleTrade();

                        break;
                    }
                case "CANCEL":
                    {
                        break;
                    }
                case "MODIFY":
                    {
                        break;
                    }
                case "PRINT":
                    {
                        break;
                    }
                default:
                    break;
            }
            Console.WriteLine(str);
        }

        public static void HandleTrade()
        {

        }

        public static void CheckForTrade()
        {

        }

        public class PriceBook
        {
            public OrderType OrderType { get; set; }
            public int Price { get; set; }
            public int Quantity { get; set; }
            public string OrderId { get; set; }
            public DateTime CurrentTime { get; set; }

            public static PriceBook CreatePriceBook(string orderType, int price, int quantity, string orderId)
            {
                return new PriceBook
                {
                    OrderType = orderType == "GFD" ? OrderType.GFD : OrderType.IOC,
                    Price = price,
                    Quantity = quantity,
                    OrderId = orderId,
                    CurrentTime = DateTime.Now
                };
            }
        }
        
        public class BuyPriceBookList : PriceBook
        {
            private Dictionary<string, PriceBook> _buyPriceBook;
            private SortedSet<PriceBook> _sortedBuyPriceBook;

            public BuyPriceBookList()
            {
                _buyPriceBook = new Dictionary<string, PriceBook>();
                _sortedBuyPriceBook = new SortedSet<PriceBook>(new PriceBookComparer());
            }
            public void Add(string key, PriceBook book)
            {
                if (!_buyPriceBook.ContainsKey(key))
                {
                    _buyPriceBook.Add(key, book);
                    _sortedBuyPriceBook.Add(book);
                }
                else
                {
                    _buyPriceBook.Remove(key);
                    _sortedBuyPriceBook.Remove(book);

                    _buyPriceBook.Add(key, book);
                    _sortedBuyPriceBook.Add(book);
                }
            }

            public void Remove(string key)
            {
                if (_buyPriceBook.ContainsKey(key))
                {
                    var book = _buyPriceBook[key];
                    _buyPriceBook.Remove(key);
                    _sortedBuyPriceBook.Remove(book);
                }
            }

            public bool ContainsKey(string key)
            {
                return _buyPriceBook.ContainsKey(key);
            }

            public PriceBook Peek()
            {
                if (_buyPriceBook.Count > 0)
                {
                    return _sortedBuyPriceBook.First();
                }

                return null;
            }

            public PriceBook GetFirstBuyBook()
            {
                if (_buyPriceBook.Count > 0)
                {
                    var book = _sortedBuyPriceBook.First();

                    _buyPriceBook.Remove(book.OrderId);
                    _sortedBuyPriceBook.Remove(book);

                    return book;
                }

                return null;
            }

            public class PriceBookComparer : IComparer<PriceBook>
            {
                public int Compare(PriceBook x, PriceBook y)
                {
                    int priceDiff = x.Price.CompareTo(y.Price);

                    if (priceDiff == 0)
                    {
                        int quantityDiff = x.Quantity.CompareTo(y.Quantity);

                        if (quantityDiff == 0)
                            return x.CurrentTime.CompareTo(y.CurrentTime);
                        else
                            return quantityDiff;
                    }
                    else
                        return priceDiff;
                }
            }
        }

        public class SellPriceBookList : PriceBook
        {
            private Dictionary<string, PriceBook> _sellPriceBook;
            private SortedSet<PriceBook> _sortedSellPriceBook;

            public SellPriceBookList()
            {
                _sellPriceBook = new Dictionary<string, PriceBook>();
                _sortedSellPriceBook = new SortedSet<PriceBook>(new PriceBookComparer());
            }
            public void Add(string key, PriceBook book)
            {
                if (!_sellPriceBook.ContainsKey(key))
                {
                    _sellPriceBook.Add(key, book);
                    _sortedSellPriceBook.Add(book);
                }
                else
                {
                    _sellPriceBook.Remove(key);
                    _sortedSellPriceBook.Remove(book);

                    _sellPriceBook.Add(key, book);
                    _sortedSellPriceBook.Add(book);
                }
            }

            public void Remove(string key)
            {
                if (_sellPriceBook.ContainsKey(key))
                {
                    var book = _sellPriceBook[key];
                    _sellPriceBook.Remove(key);
                    _sortedSellPriceBook.Remove(book);
                }
            }

            public bool ContainsKey(string key)
            {
                return _sellPriceBook.ContainsKey(key);
            }

            public PriceBook Peek()
            {
                if (_sellPriceBook.Count > 0)
                {
                    return _sortedSellPriceBook.First();
                }

                return null;
            }

            public PriceBook GetFirstBuyBook()
            {
                if (_sellPriceBook.Count > 0)
                {
                    var book = _sortedSellPriceBook.First();

                    _sellPriceBook.Remove(book.OrderId);
                    _sortedSellPriceBook.Remove(book);

                    return book;
                }

                return null;
            }

            public class PriceBookComparer : IComparer<PriceBook>
            {
                public int Compare(PriceBook x, PriceBook y)
                {
                    int priceDiff = y.Price.CompareTo(x.Price);

                    if (priceDiff == 0)
                    {
                        int quantityDiff = y.Quantity.CompareTo(x.Quantity);

                        if (quantityDiff == 0)
                            return y.CurrentTime.CompareTo(x.CurrentTime);
                        else
                            return quantityDiff;
                    }
                    else
                        return priceDiff;
                }
            }
        }

        public enum OrderType
        {
            GFD = 0,
            IOC = 1
        }
    }
}