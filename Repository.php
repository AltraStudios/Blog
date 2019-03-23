<?php namespace App\Repositories;

use Illuminate\Database\Eloquent\Model;

class Repository implements IRepository
{
    // model property on class instances
    protected $model;

    // Constructor to bind model to repo
    public function __construct(Model $model)
    {
        $this->model = $model;
    }

    // Get all instances of model
    public function all()
    {
        return $this->model->all();
    }

    // Get array of records by page number
    public function getPage($pageNum, $pageSize)
    {
        return $this->model->take($pageSize)->skip(($pageNum-1) * $pageSize)->get();
    }

    // create a new record in the database
    public function create(array $data)
    {
        return $this->model->create($data);
    }

    // update record in the database
    public function update(array $data, $id)
    {
        $record = $this->model->find($id);
        return $record->update($data);
    }

    // remove record from the database
    public function delete($id)
    {
        return $this->model->destroy($id);
    }

    // show the record with the given id
    public function show($id)
    {
        return $this->model->find($id);
    }

    // search with a column pattern
    public function search($column, $pattern, $selects)
    {
        $query = $this->model->where($column, '=', $pattern);
        if(is_null($selects) == false)
        {
            foreach ($selects as $selectColumn)
            {
                $query->addSelect($selectColumn);
            }
        }
        return $query->first();
    }

    // search with a column pattern returns multiple elements
    public function searchAll($column, $pattern, $selects)
    {
        $query = $this->model->where($column, '=', $pattern);
        if(is_null($selects) == false)
        {
            foreach ($selects as $selectColumn)
            {
                $query->addSelect($selectColumn);
            }
        }
        return $query->get();
    }

    // apply a group of filters and return a single element
    public function filter($filters)
    {
        return $this->model->where($filters)->first();
    }

    // apply a group of filters and return multiple elements
    public function filterAll($filters)
    {
        return $this->model->where($filters)->get();
    }

    // apply a group of filters and return multiple elements
    public function filterAllGetPage($filters, $page, $pageCount)
    {
        return $this->model->where($filters)->take($pageCount)->skip(($page-1) * $pageCount)->get();
    }

    // Get the associated model
    public function getModel()
    {
        return $this->model;
    }

    // Set the associated model
    public function setModel($model)
    {
        $this->model = $model;
        return $this;
    }

    // Eager load database relationships
    public function with($relations)
    {
        return $this->model->with($relations);
    }
}
