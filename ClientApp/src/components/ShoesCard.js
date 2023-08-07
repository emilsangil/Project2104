import React from "react";
import ShoeCard from "./ShoeCard";
import "./../styles/ShoesCard.css";

const ShoesCard = ({ isFavorites }) => {
    const shoeCards = Array.from({ length: 12 }, (_, index) => (
        <ShoeCard key={index} isFavorites={isFavorites} />
    ));
    return (
        <section className="ShoesContainer">
            {shoeCards}
        </section>
    )
}

export default ShoesCard;