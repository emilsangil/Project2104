import React from "react";
import ShoeCard from "./ShoeCard";
import "./../styles/ShoesCard.css";

const ShoesCard = ({ isFavorites, shoes, userId }) => {
    //const shoeCards = Array.from({ length: 12 }, (_, index) => (
    //    <ShoeCard key={index} isFavorites={isFavorites} />
    //));
    return (
        <section className="ShoesContainer">
            {shoes.map((shoe, index) => (
                <ShoeCard key={index} shoe={shoe} isFavorites={isFavorites} userId={ userId } />
            )) }
        </section>
    )
}

export default ShoesCard;