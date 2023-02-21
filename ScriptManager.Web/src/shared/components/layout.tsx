import React from "react";
import { Link, Outlet } from "react-router-dom";

export const MainLayout = (props: any) => {
  return (
    <>
      {" "}
      <div className="container-fluid p-0">
        <div className="container-fluid">
          <div className="row flex-nowrap">
            <div className="col-auto col-md-3 col-xl-2 px-sm-2 px-0 bg-dark">
              <div className="d-flex flex-column align-items-center align-items-sm-start px-3 pt-2 text-white min-vh-100">
                <Link
                  to="/"
                  className="d-flex align-items-center pb-3 mb-md-0 me-md-auto text-white text-decoration-none"
                >
                  <h3 className="fs-5 d-none d-sm-inline">
                    {" "}
                    <b> Script Center</b>
                  </h3>
                </Link>
                <ul
                  className="nav nav-pills flex-column mb-sm-auto mb-0 align-items-center align-items-sm-start"
                  id="menu"
                >
                  <li>
                    <Link
                      to="/scripts"
                      data-bs-toggle="collapse"
                      className="nav-link px-0 align-middle"
                    >
                      <i className="fs-4 bi-speedometer2"></i>{" "}
                      <h5 className="ms-1 d-none d-sm-inline text-white">
                        <b> Scripts</b>
                      </h5>
                    </Link>
                  </li>
                </ul>
              </div>
            </div>
            <div className="col py-3">
              <Outlet />
            </div>
          </div>
        </div>
      </div>
    </>
  );
};
