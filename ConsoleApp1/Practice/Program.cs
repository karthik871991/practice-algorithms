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
            var buyList = new BuyPriceBookList();
            var sellList = new SellPriceBookList();

            while (true)
            {
                var str = Console.ReadLine();
                RunOrderMatchingEngine(str, buyList, sellList);
            }
        }

        public static void RunOrderMatchingEngine(string str, BuyPriceBookList buyList, SellPriceBookList sellList)
        {
            var strArray = str.Split(' ');

            switch (strArray[0])
            {
                case "BUY":
                    {
                        var orderId = strArray[4];
                        var book = PriceBook.CreatePriceBook(strArray[1], int.Parse(strArray[2]), int.Parse(strArray[3]), strArray[4]);
                        //buyList.Add(orderId, book);

                        AddBuySellTransaction(buyList, sellList, book, "BUY");

                        HandleTrade();

                        break;
                    }
                case "SELL":
                    {
                        var orderId = strArray[4];
                        var book = PriceBook.CreatePriceBook(strArray[1], int.Parse(strArray[2]), int.Parse(strArray[3]), strArray[4]);
                        //sellList.Add(orderId, book);

                        AddBuySellTransaction(buyList, sellList, book, "SELL");
                        HandleTrade();

                        break;
                    }
                case "CANCEL":
                    {
                        var orderId = strArray[1];
                        if (buyList.ContainsKey(orderId))
                            buyList.Remove(orderId);

                        if (sellList.ContainsKey(orderId))
                            sellList.Remove(orderId);

                        break;
                    }
                case "MODIFY":
                    {
                        var orderId = strArray[1];
                        var buyOrSell = strArray[2];
                        var newPrice = int.Parse(strArray[3]);
                        var newQuantity = int.Parse(strArray[4]);

                        PriceBook book = null;

                        if (buyList.ContainsKey(orderId))
                        {
                            book = buyList.Get(orderId);
                            buyList.Remove(orderId);
                        }

                        if (sellList.ContainsKey(orderId))
                        {
                            book = sellList.Get(orderId);
                            sellList.Remove(orderId);
                        }

                        book.CurrentTime = DateTime.Now;
                        book.Price = int.Parse(strArray[3]);
                        book.Quantity = int.Parse(strArray[4]);

                        AddBuySellTransaction(buyList, sellList, book, strArray[2]);
                        HandleTrade();
                        break;
                    }
                case "PRINT":
                    {
                        Print(buyList, sellList);
                        break;
                    }
                default:
                    break;
            }
            Console.WriteLine(str);
        }

        public static void AddBuySellTransaction(BuyPriceBookList buyList, SellPriceBookList sellList, PriceBook book, string priceBookType)
        {
            if (priceBookType == "BUY")
                buyList.Add(book.OrderId, book);

            if (priceBookType == "SELL")
                sellList.Add(book.OrderId, book);
        }

        public static void HandleTrade()
        {

        }

        public static void Print(BuyPriceBookList buyList, SellPriceBookList sellList)
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

            public PriceBook Get(string key)
            {
                if (ContainsKey(key))
                    return _buyPriceBook[key];

                return null;
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

            public void Dump()
            {
                foreach (var key in _sortedBuyPriceBook)
                {
                    Console.WriteLine(_buyPriceBook[key.OrderId].Price);
                }
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

            public PriceBook Get(string key)
            {
                if (ContainsKey(key))
                    return _sellPriceBook[key];

                return null;
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

            public void Dump()
            {

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