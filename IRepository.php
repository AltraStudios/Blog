<?php namespace App\Repositories;

interface IRepository
{
    /**
     * Get All Model Objects
     */
    public function all();

    /**
     * Get Model Objects with pagination
     */

    public function getPage($pageNum, $pageSize);

    /**
     * Store Object
     */
    public function create(array $data);

    /**
     * Update Object by Id
     */
    public function update(array $data, $id);

    /**
     * Delete Object by id
     */
    public function delete($id);

    /**
     * Show Object by id
     */
    public function show($id);

    /**
     * Search by $column that matches $pattern and select columns $selects
     */
    public function search($column, $pattern, $selects);
}
