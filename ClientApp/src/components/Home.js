import React from 'react';
import HomeBanner from "./HomeBanner";
import "./../styles/Home.css";
import ShoesCard from "./ShoesCard";


const Home = () => {
    return(
        <main className="MainContainer">
            <HomeBanner />
            <ShoesCard />
        </main>
    )
}

export default Home;