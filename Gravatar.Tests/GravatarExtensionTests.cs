using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gravatar.Tests
{
    [TestClass]
    public class GravatarExtensionTests{

        [TestCategory("Gravatar Tests")]
        [TestMethod("Should validate Gravatar extension")]
        [DataRow(null, false)]
        [DataRow("", false)]
        [DataRow(" ", false)]
        [DataRow("c@z", false)]
        [DataRow("c@zarpsystem.com.br", false)]
        [DataRow("carlos.santana@zarpsystem.com.br", true)]
        public void ShouldValidateGravatar(string email, bool status){

            var result = "https://www.gravatar.com/avatar/c0c80e8b046d49dd27432dd7166d16bd";
            Assert.AreEqual((email.ToGravatar() == result), status);
            
        }
      
    }
}
