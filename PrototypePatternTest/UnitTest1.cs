using PrototypePattern;

namespace PrototypePatternTest
{
    public class UnitTest1
    {
        [Fact]
        public void DogClone_ShouldReturnExactCopy()
        {
            // Arrange
            Dog originalDog = new() { Name = "Рекс", Age = 5, Legs = 4, Breed = "Labrador" };

            // Act
            var clonedDog = (Dog)originalDog.Clone();

            // Assert
            Assert.NotSame(originalDog, clonedDog);
            Assert.Equal(originalDog.Name, clonedDog.Name);
            Assert.Equal(originalDog.Age, clonedDog.Age);
            Assert.Equal(originalDog.Legs, clonedDog.Legs);
            Assert.Equal(originalDog.Breed, clonedDog.Breed);
        }

        [Fact]
        public void DogMyClone_ShouldReturnExactCopy()
        {
            // Arrange
            Dog originalDog = new() { Name = "Рекс", Age = 5, Legs = 4, Breed = "Labrador" };

            // Act
            Dog clonedDog = originalDog.MyClone();

            // Assert
            Assert.NotSame(originalDog, clonedDog);
            Assert.Equal(originalDog.Name, clonedDog.Name);
            Assert.Equal(originalDog.Age, clonedDog.Age);
            Assert.Equal(originalDog.Legs, clonedDog.Legs);
            Assert.Equal(originalDog.Breed, clonedDog.Breed);
        }

        [Fact]
        public void CatClone_ShouldReturnExactCopy()
        {
            // Arrange
            Cat originalCat = new() { Name = "Муся", Age = 3, Legs = 4, FurColor = "Black" };

            // Act
            Cat clonedCat = (Cat)originalCat.Clone();

            // Assert
            Assert.NotSame(originalCat, clonedCat);
            Assert.Equal(originalCat.Name, clonedCat.Name);
            Assert.Equal(originalCat.Age, clonedCat.Age);
            Assert.Equal(originalCat.Legs, clonedCat.Legs);
            Assert.Equal(originalCat.FurColor, clonedCat.FurColor);
        }

        [Fact]
        public void CatMyClone_ShouldReturnExactCopy()
        {
            // Arrange
            Cat originalCat = new() { Name = "Муся", Age = 3, Legs = 4, FurColor = "Black" };

            // Act
            Cat clonedCat = originalCat.MyClone();

            // Assert
            Assert.NotSame(originalCat, clonedCat);
            Assert.Equal(originalCat.Name, clonedCat.Name);
            Assert.Equal(originalCat.Age, clonedCat.Age);
            Assert.Equal(originalCat.Legs, clonedCat.Legs);
            Assert.Equal(originalCat.FurColor, clonedCat.FurColor);
        }

        [Fact]
        public void MammalClone_ShouldReturnExactCopy()
        {
            // Arrange
            Mammal originalMammal = new() { Name = "Млекопитающее", Age = 4, Legs = 4 };

            // Act
            Mammal clonedMammal = (Mammal)originalMammal.Clone();

            // Assert
            Assert.NotSame(originalMammal, clonedMammal);
            Assert.Equal(originalMammal.Name, clonedMammal.Name);
            Assert.Equal(originalMammal.Age, clonedMammal.Age);
            Assert.Equal(originalMammal.Legs, clonedMammal.Legs);
        }

        [Fact]
        public void MammalMyClone_ShouldReturnExactCopy()
        {
            // Arrange
            Mammal originalMammal = new() { Name = "Млекопитающее", Age = 4, Legs = 4 };

            // Act
            Mammal clonedMammal = originalMammal.MyClone();

            // Assert
            Assert.NotSame(originalMammal, clonedMammal);
            Assert.Equal(originalMammal.Name, clonedMammal.Name);
            Assert.Equal(originalMammal.Age, clonedMammal.Age);
            Assert.Equal(originalMammal.Legs, clonedMammal.Legs);
        }

        [Fact]
        public void AnimalClone_ShouldReturnExactCopy()
        {
            // Arrange
            Animal originalAnimal = new() { Name = "Грязное животное", Age = 2 };

            // Act
            Animal clonedAnimal = (Animal)originalAnimal.Clone();

            // Assert
            Assert.NotSame(originalAnimal, clonedAnimal);
            Assert.Equal(originalAnimal.Name, clonedAnimal.Name);
            Assert.Equal(originalAnimal.Age, clonedAnimal.Age);
        }

        [Fact]
        public void AnimalMyClone_ShouldReturnExactCopy()
        {
            // Arrange
            Animal originalAnimal = new() { Name = "Грязное животное", Age = 2 };

            // Act
            Animal clonedAnimal = originalAnimal.MyClone();

            // Assert
            Assert.NotSame(originalAnimal, clonedAnimal);
            Assert.Equal(originalAnimal.Name, clonedAnimal.Name);
            Assert.Equal(originalAnimal.Age, clonedAnimal.Age);
        }
    }
}