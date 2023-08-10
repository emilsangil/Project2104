import { Counter } from "./components/Counter";
import { FetchData } from "./components/FetchData";
import Home from "./components/Home";
import ShoeDetails from "./components/ShoeDetails";
import Favorites from "./components/Favorites";
import Profile from "./components/Profile";
import Signup from "./components/Signup";
import Search from "./components/Search";
import Women from "./components/Womens";
import Kids from "./components/Kids";

const AppRoutes = [
  {
    index: true,
    element: <Home />
    },
  {
      path: "/shoedetails/:id",
      element: <ShoeDetails />
    },
    {
        path: "/favorites",
        element: <Favorites />
    },
    {
        path: "/signup",
        element: <Signup />
    },
    {
        path: "/search",
        element: <Search />
    },
    {
        path: "/profile",
        element: <Profile />
    },
    {
        path: "/women",
        element: <Women />
    },
    {
        path: "/Kids",
        element: <Kids />
    },
  {
    path: '/counter',
    element: <Counter />
  },
  {
    path: '/fetch-data',
    element: <FetchData />
  }
];

export default AppRoutes;
