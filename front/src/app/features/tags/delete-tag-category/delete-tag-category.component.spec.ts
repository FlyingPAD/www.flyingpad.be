import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeleteTagCategoryComponent } from './delete-tag-category.component';

describe('DeleteTagCategoryComponent', () => {
  let component: DeleteTagCategoryComponent;
  let fixture: ComponentFixture<DeleteTagCategoryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [DeleteTagCategoryComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(DeleteTagCategoryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
