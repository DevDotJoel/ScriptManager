import React, { useEffect, useState } from "react";
import { Modal } from "react-bootstrap";
import { Link } from "react-router-dom";
import { apiUrl } from "../../shared/enviroment/enviroment";

export const ScriptsPage = () => {
  const [scripts, setScripts] = useState([]);
  const [script, setScript] = useState<any>({});
  const [show, setShow] = useState(false);
  const handleClose = () => setShow(false);
  const handleShow = () => setShow(true);

  useEffect(() => {
    const init = async () => {
      await getData();
    };

    init();
  }, []);

  async function getData() {
    const res = await fetch(`${apiUrl}api/Script`);
    // The return value is *not* serialized
    // You can return Date, Map, Set, etc.

    // Recommendation: handle errors
    if (!res.ok) {
      // This will activate the closest `error.js` Error Boundary
      throw new Error("Failed to fetch data");
    }

    return setScripts(await res.json());
  }
  function deleteScript(id: number) {
    const currentScript = scripts.find((script: any) => script.id === id);
    setScript(currentScript);
  }
  return (
    <>
      <div className="row mt-3">
        <div className="col">
          <h1>
            <b>Scripts</b>
          </h1>
        </div>
        <div className="col  d-flex justify-content-end">
          <div>
            <button className="btn btn-dark "> Add Script</button>
          </div>
        </div>
      </div>

      <div className="row d-flex justify-content-center mt-5">
        <div className="col ">
          <div className="card shadow rounded">
            <div className="card-body">
              <div className="row mt-3">
                <div className="col col-sm-5">
                  <input
                    placeholder="search "
                    type="text"
                    className="form-control rounded"
                    id="search"
                    aria-describedby="emailHelp"
                  />
                </div>
                <div className="col">
                  <button className="btn btn-dark"> search</button>
                </div>
              </div>
              <div className="row mt-3">
                <div className="col">
                  <table className="table ">
                    <thead>
                      <tr>
                        <th>Nome</th>
                        <th>Número de Perguntas</th>
                        <th>Ações</th>
                      </tr>
                    </thead>
                    <tbody>
                      {scripts.map((script: any) => (
                        <tr key={script.id}>
                          <td>{script.name}</td>
                          <td>{script.questions.length}</td>
                          <td>
                            <div className="d-flex flex-row">
                              <div>
                                <Link
                                  to={`/scripts/${script.id}`}
                                  className="btn btn-dark  d-block    "
                                >
                                  Edit
                                </Link>
                              </div>
                              <div>
                                <button
                                  onClick={() => {
                                    deleteScript(script.id);
                                    handleShow();
                                  }}
                                  className="btn btn-danger d-block ms-2 "
                                >
                                  Delete
                                </button>
                              </div>
                            </div>
                          </td>
                        </tr>
                      ))}
                    </tbody>
                  </table>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>

      <Modal show={show} onHide={handleClose}>
        <Modal.Header closeButton>
          <Modal.Title className="text-center">
            <h5>Apagar Script</h5>
          </Modal.Title>
        </Modal.Header>
        <Modal.Body>
          <div className="row">
            <div className="col">
              <h5>
                Tem a certeza que quer apagar o script com o nome {script.name}
              </h5>
            </div>
          </div>
        </Modal.Body>
        <Modal.Footer className=" justify-content-between">
          <button
            onClick={handleClose}
            className="btn btn-default text-muted w-25"
          >
            Cancel
          </button>
          <button className=" btn btn-danger w-25">Yes</button>
        </Modal.Footer>
      </Modal>
    </>
  );
};
