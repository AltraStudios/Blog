<?php namespace App\Services;
use App\Series;
use App\Repositories\Repository;
class ModelService
{

    protected $model;

    public function __construct(MyModel $model)
    {
        $this->model = new Repository($model);
    }

    public function GetAll()
    {
        return $this->model->all();
    }
}
