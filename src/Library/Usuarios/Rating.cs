using System;
using System.Collections.Generic;
using System.Linq;

namespace RideShare;

public class Rating
{
    List<int> Ratings { get; set; }
    public int AverageRating { get; set; }

    public Rating()
    {
        this.Ratings = new List<int> { };
        this.AverageRating = 0;
    }

    // Se obtendra el promedio de la calificaciones con un rango de 1 hasta 5, dividio entre el numero de calificaciones
    public void AddRating(int rating)
    {
        this.Ratings.Add(rating);
        this.AverageRating = (this.Ratings.Sum()) / this.Ratings.Count;
        
    }
    
    public int GetAverageRating()
    {
        return this.AverageRating;

    }
}