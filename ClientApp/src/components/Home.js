import React from 'react';
import HomeBanner from "./HomeBanner";
import "./../styles/Home.css";
import ShoesCard from "./ShoesCard";


const Home = () => {
    return(
        <main className="MainContainer">
            <HomeBanner imageUrl="/images/RetroHighOGChicago1.png" ShoeClass="AIR JORDAN 1" ShoeName="Retro High OG Chicago"/>
            <ShoesCard />
        </main>
    )
}

export default Home;