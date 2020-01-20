using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgoPractice
{
    // Sample Inputs
    //    SELL GFD 1000 10 ORDER1

    //SELL GFD 3000 20 ORDER2

    //SELL GFD 2000 20 ORDER3

    //SELL GFD 3000 20 ORDER4
    //SELL GFD 1000 20 ORDER5

    //PRINT

    //BUY GFD 1000 10 ORDER1

    //SELL GFD 9000 10 ORDER2
    //BUY IOC 9000 15 ORDER3
    //CANCEL ORDER1

    //SELL GFD 900 10 ORDER2
    //BUY GFD 1000 10 ORDER1



    //BUY GFD 1000 10 ORDER1

    //BUY GFD 1000 10 ORDER2
    //SELL GFD 900 20 ORDER3




    //BUY GFD 950 10 ORDER1

    //BUY GFD 1000 15 ORDER2
    //SELL GFD 900 20 ORDER3



    //BUY GFD 1000 10 ORDER1

    //BUY GFD 1000 10 ORDER2
    //MODIFY ORDER1 BUY 1000 20
    //SELL GFD 900 20 ORDER3
    //-------------------------------------
    //BUY GFD 1000 10 ORDER1

    //PRINT

    //BUY GFD 1000 10 ORDER1

    //BUY GFD 1000 20 ORDER2
    //PRINT

    //BUY GFD 1000 10 ORDER1

    //BUY GFD 1001 20 ORDER2
    //PRINT

    //BUY GFD 1000 10 ORDER1

    //SELL GFD 900 20 ORDER2
    //PRINT

    //BUY GFD 1000 10 ORDER1

    //BUY GFD 1010 10 ORDER2
    //SELL GFD 1000 15 ORDER3
    //PRINT
    class AkunaCapital
    {
        public class Sample
        {
            public int A { get; set; }
            public int B { get; set; }
        }
        static void Somethind(string[] args)
        {
            var list = new List<Sample>();

            for (int i = 0; i < int.MaxValue; i++)
            {
                list.Add(new Sample { A = i, B = i });
            }

            var a = "";
            var b = "asa";
            var c = a ?? b;
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

                        HandleGFDTrade(buyList, sellList);
                        if (book.OrderType == OrderType.IOC)
                        {
                            buyList.Remove(book.OrderId);
                        }
                        break;
                    }
                case "SELL":
                    {
                        var orderId = strArray[4];
                        var book = PriceBook.CreatePriceBook(strArray[1], int.Parse(strArray[2]), int.Parse(strArray[3]), strArray[4]);
                        //sellList.Add(orderId, book);

                        AddBuySellTransaction(buyList, sellList, book, "SELL");
                        HandleGFDTrade(buyList, sellList);
                        if (book.OrderType == OrderType.IOC)
                        {
                            sellList.Remove(book.OrderId);
                        }
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

                        var newBook = PriceBook.CreatePriceBook("GFD", newPrice, newQuantity, orderId);

                        AddBuySellTransaction(buyList, sellList, newBook, strArray[2]);
                        HandleGFDTrade(buyList, sellList);
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
        }

        public static void AddBuySellTransaction(BuyPriceBookList buyList, SellPriceBookList sellList, PriceBook book, string priceBookType)
        {
            if (book.Price <= 0 || book.Quantity <= 0 || string.IsNullOrWhiteSpace(book.OrderId))
                return;

            if (priceBookType == "BUY")
                buyList.Add(book.OrderId, book);

            if (priceBookType == "SELL")
                sellList.Add(book.OrderId, book);
        }

        public static void HandleGFDTrade(BuyPriceBookList buyList, SellPriceBookList sellList)
        {
            var buyBookPeek = buyList.Peek();
            var sellBookPeek = sellList.Peek();

            if (buyBookPeek == null || sellBookPeek == null)
                return;

            if (buyBookPeek.Price >= sellBookPeek.Price)
            {
                var buy = buyList.GetFirstBuyBook();
                var sell = sellList.GetFirstBuyBook();

                var quantityTraded = Math.Min(buy.Quantity, sell.Quantity);

                if (buyBookPeek.CurrentTime < sellBookPeek.CurrentTime)
                {
                    Console.WriteLine($"TRADE {buy.OrderId} {buy.Price} {quantityTraded} " +
                        $"{sell.OrderId} {sell.Price} {quantityTraded}");
                }
                else
                {
                    Console.WriteLine($"TRADE {sell.OrderId} {sell.Price} {quantityTraded} " +
                        $"{buy.OrderId} {buy.Price} {quantityTraded}");
                }

                if (buy.Quantity - quantityTraded > 0)
                {
                    buy.Quantity = buy.Quantity - quantityTraded;
                    buyList.Add(buy.OrderId, buy);
                }

                if (sell.Quantity - quantityTraded > 0)
                {
                    sell.Quantity = sell.Quantity - quantityTraded;
                    sellList.Add(sell.OrderId, sell);
                }

                HandleGFDTrade(buyList, sellList);
            }
            else
            {
                return;
            }
        }

        public static void Print(BuyPriceBookList buyList, SellPriceBookList sellList)
        {
            sellList.Dump();
            buyList.Dump();
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
        public class PriceBookComparer : IComparer<PriceBook>
        {
            public int Compare(PriceBook x, PriceBook y)
            {
                int priceDiff = x.Price.CompareTo(y.Price);

                if (priceDiff == 0)
                {
                    return x.CurrentTime.CompareTo(y.CurrentTime);
                }
                else
                    return priceDiff;
            }
        }
        public class Node
        {
            public int Key { get; set; }
            public int Value { get; set; }
        }
        public class PriceBookList
        {
            protected Dictionary<string, PriceBook> _priceBook;
            protected SortedSet<PriceBook> _sortedPriceBook;

            private PriceBookList()
            {

            }

            public PriceBookList(PriceBookComparer comparer)
            {
                _priceBook = new Dictionary<string, PriceBook>();
                _sortedPriceBook = new SortedSet<PriceBook>(comparer);
            }

            public PriceBookList(PriceBookReverseComparer comparer)
            {
                _priceBook = new Dictionary<string, PriceBook>();
                _sortedPriceBook = new SortedSet<PriceBook>(comparer);
            }

            public void Add(string key, PriceBook book)
            {
                if (!_priceBook.ContainsKey(key))
                {
                    _priceBook.Add(key, book);
                    _sortedPriceBook.Add(book);
                }
                else
                {
                    _priceBook.Remove(key);
                    _sortedPriceBook.Remove(book);

                    _priceBook.Add(key, book);
                    _sortedPriceBook.Add(book);
                }
            }

            public void Remove(string key)
            {
                if (_priceBook.ContainsKey(key))
                {
                    var book = _priceBook[key];
                    _priceBook.Remove(key);
                    _sortedPriceBook.Remove(book);
                }
            }

            public PriceBook Get(string key)
            {
                if (ContainsKey(key))
                    return _priceBook[key];

                return null;
            }

            public bool ContainsKey(string key)
            {
                return _priceBook.ContainsKey(key);
            }

            public PriceBook Peek()
            {
                if (_priceBook.Count > 0)
                {
                    return _sortedPriceBook.First();
                }

                return null;
            }

            public PriceBook GetFirstBuyBook()
            {
                if (_priceBook.Count > 0)
                {
                    var book = _sortedPriceBook.First();

                    _priceBook.Remove(book.OrderId);
                    _sortedPriceBook.Remove(book);

                    return book;
                }

                return null;
            }

            public virtual void Dump()
            {
                foreach (var key in _sortedPriceBook)
                {
                    Console.WriteLine(_priceBook[key.OrderId].Price);
                }
            }
        }

        public class BuyPriceBookList : PriceBookList
        {
            public BuyPriceBookList() : base(new PriceBookReverseComparer())
            {

            }

            public class Node
            {
                public int Key { get; set; }
                public int Value { get; set; }
            }

            public override void Dump()
            {
                Console.WriteLine("BUY:");

                var list = new LinkedList<Node>();

                foreach (var key in _sortedPriceBook)
                {
                    var lastValue = list.LastOrDefault();

                    if (lastValue == null)
                        list.AddLast(new Node { Key = _priceBook[key.OrderId].Price, Value = _priceBook[key.OrderId].Quantity });
                    else
                    {
                        if (lastValue.Key == key.Price)
                        {
                            lastValue.Value += key.Quantity;
                        }
                        else
                        {
                            list.AddLast(new Node { Key = _priceBook[key.OrderId].Price, Value = _priceBook[key.OrderId].Quantity });
                        }
                    }
                    //Console.WriteLine($"{_priceBook[key.OrderId].Price} {_priceBook[key.OrderId].Quantity}");
                }

                foreach (var node in list)
                {
                    Console.WriteLine($"{node.Key} {node.Value}");
                }
            }
        }

        public class PriceBookReverseComparer : IComparer<PriceBook>
        {
            public int Compare(PriceBook x, PriceBook y)
            {
                int priceDiff = y.Price.CompareTo(x.Price);

                if (priceDiff == 0)
                {
                    return x.CurrentTime.CompareTo(y.CurrentTime);
                }
                else
                    return priceDiff;
            }
        }

        public class SellPriceBookList : PriceBookList
        {
            public SellPriceBookList() : base(new PriceBookComparer())
            {

            }

            public override void Dump()
            {
                Console.WriteLine("SELL:");

                var list = new LinkedList<Node>();

                foreach (var key in _sortedPriceBook.Reverse())
                {
                    var lastValue = list.LastOrDefault();

                    if (lastValue == null)
                        list.AddLast(new Node { Key = _priceBook[key.OrderId].Price, Value = _priceBook[key.OrderId].Quantity });
                    else
                    {
                        if (lastValue.Key == key.Price)
                        {
                            lastValue.Value += key.Quantity;
                        }
                        else
                        {
                            list.AddLast(new Node { Key = _priceBook[key.OrderId].Price, Value = _priceBook[key.OrderId].Quantity });
                        }
                    }
                }

                foreach (var node in list)
                {
                    Console.WriteLine($"{node.Key} {node.Value}");
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
