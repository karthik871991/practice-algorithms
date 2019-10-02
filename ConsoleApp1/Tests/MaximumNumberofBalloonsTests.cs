using AlgoPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestClass]
    public class MaximumNumberofBalloonsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "nlaebolko";

            var result = new MaximumNumberofBalloons().MaxNumberOfBalloons(input);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string input = "loonbalxballpoon";

            var result = new MaximumNumberofBalloons().MaxNumberOfBalloons(input);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string input = "loonbalxballpoonloonbalxballpoon";

            var result = new MaximumNumberofBalloons().MaxNumberOfBalloons(input);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string input = "leetcode";

            var result = new MaximumNumberofBalloons().MaxNumberOfBalloons(input);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            string input = "balon";

            var result = new MaximumNumberofBalloons().MaxNumberOfBalloons(input);

            Assert.AreEqual(0, result);
        }
        
        [TestMethod]
        public void TestMethod6()
        {
            string input = "krhizmmgmcrecekgyljqkldocicziihtgpqwbticmvuyznragqoyrukzopfmjhjjxemsxmrsxuqmnkrzhgvtgdgtykhcglurvppvcwhrhrjoislonvvglhdciilduvuiebmffaagxerjeewmtcwmhmtwlxtvlbocczlrppmpjbpnifqtlninyzjtmazxdbzwxthpvrfulvrspycqcghuopjirzoeuqhetnbrcdakilzmklxwudxxhwilasbjjhhfgghogqoofsufysmcqeilaivtmfziumjloewbkjvaahsaaggteppqyuoylgpbdwqubaalfwcqrjeycjbbpifjbpigjdnnswocusuprydgrtxuaojeriigwumlovafxnpibjopjfqzrwemoinmptxddgcszmfprdrichjeqcvikynzigleaajcysusqasqadjemgnyvmzmbcfrttrzonwafrnedglhpudovigwvpimttiketopkvqw";

            var result = new MaximumNumberofBalloons().MaxNumberOfBalloons(input);

            Assert.AreEqual(0, result);
        }
    }
}
