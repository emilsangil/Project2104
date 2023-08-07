import React from "react";
import "./../styles/Favorites.css";
import ShoesCard from "./ShoesCard";

const Favorites = () => {
    return (
        <article className="FavoritesContainer">
            <p>FAVORITES</p>
            <ShoesCard isFavorites={true} />
        </article>
    )
}

export default Favorites;